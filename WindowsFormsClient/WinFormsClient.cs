using Microsoft.AspNet.SignalR.Client;
using System;
using System.Net.Http;
using System.Windows.Forms;

using System.IO;


namespace WinFormsClient
{
    /// <summary>
    /// SignalR client hosted in a WinForms application. The client
    /// lets the user pick a user name, connect to the server asynchronously
    /// to not block the UI thread, and send chat messages to all connected 
    /// clients whether they are hosted in WinForms, WPF, or a web application.
    /// </summary>
    public partial class WinFormsClient : Form
    {
        /// <summary>
        /// This name is simply added to sent messages to identify the user; this 
        /// sample does not include authentication.
        /// </summary>
        private String UserName { get; set; }
        private IHubProxy HubProxy { get; set; }
        const string ServerURI = "http://localhost:8080/signalr";
        private HubConnection Connection { get; set; }

        FolderBrowserDialog monFdBrow = new FolderBrowserDialog();
        FolderBrowserDialog saveFdBrow = new FolderBrowserDialog();
        FileSystemWatcher watcher = new FileSystemWatcher();
        string nameFileSave = "";

        internal WinFormsClient()
        {
            InitializeComponent();
            Random rand = new Random();
            nameFileSave = DateTime.Now.ToString("ddMMMMyyyy")+"_" + rand.Next() + ".txt";

            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName
                | NotifyFilters.DirectoryName;

            watcher.Filter = "*.txt";

            
        }

        public void watcherDirectory(string directory)
        {
            
            watcher.Path = directory;
            watcher.Created += new FileSystemEventHandler(OnAdd);
            watcher.EnableRaisingEvents = true;
        }

        public void saveDirectory(string directory)
        {
            watcher.Path = directory;
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;
        }
  
        public void OnAdd(object source, FileSystemEventArgs e)
        {
            RichTextBoxConsole.Invoke((Action)(() =>
            {
                RichTextBoxConsole.AppendText(String.Format("File: {0} | {1}" + Environment.NewLine, e.FullPath, e.ChangeType));

                try
                {
                    string[] file = File.ReadAllLines(e.FullPath);

                    for (int i = 0; i < file.Length; i++)
                    {
                        file[i] = file[i].Replace(" ", string.Empty);
                        file[i] = file[i].Trim().Replace(" ", string.Empty);
                        int index = file[i].IndexOf(':');
                        string name = file[i].Remove(index - 1);
                        string text = file[i].Remove(0, index);
                        HubProxy.Invoke("Send", name, text);
                    }
                    File.Delete(e.FullPath);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                
            }));
        }

        public  void OnChanged(object source, FileSystemEventArgs e)
        {
            RichTextBoxConsole.Invoke((MethodInvoker)delegate
            {
                RichTextBoxConsole.AppendText(String.Format("File: {0} | {1}" + Environment.NewLine, e.FullPath, e.ChangeType));
            });
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            HubProxy.Invoke("Send", UserName, TextBoxMessage.Text);
            TextBoxMessage.Text = String.Empty;
            TextBoxMessage.Focus();
        }

        public void filewriter(string message)
        {
           
                string path = saveFdBrow.SelectedPath;
                StreamWriter files = new StreamWriter(path + "/" + nameFileSave);
                files.WriteLine(message);
                files.Close();
        }
        /// <summary>
        /// Creates and connects the hub connection and hub proxy. This method
        /// is called asynchronously from SignInButton_Click.
        /// </summary>
        

        private async void ConnectAsync()
        {
            Connection = new HubConnection(ServerURI);
            Connection.Closed += Connection_Closed;
            HubProxy = Connection.CreateHubProxy("MyHub");
            string messag;
            //Handle incoming event from server: use Invoke to write to console from SignalR's thread
            HubProxy.On<string, string>("AddMessage", (name, message) =>
                this.Invoke((Action)(() =>
                {
                    messag = String.Format("{0}: {1}" + Environment.NewLine, name, message);
                    if (string.IsNullOrWhiteSpace(saveFdBrow.SelectedPath))
                    {
                        MessageBox.Show("Директория для сохранений должна быть выбрана");
                        SaveFolder();
                        return;
                    }
                    filewriter(messag);
                    RichTextBoxConsole.AppendText(messag);
                    
                }
                    ))
            );
            try
            {
                await Connection.Start();
            }
            catch (HttpRequestException)
            {
                StatusText.Text = "Unable to connect to server: Start server before connecting clients.";
                //No connection: Don't enable Send button or show chat UI
                return;
            }

            //Activate UI
            SignInPanel.Visible = false;
            ChatPanel.Visible = true;
            ButtonSend.Enabled = true;
            TextBoxMessage.Focus();
            RichTextBoxConsole.AppendText("Connected to server at " + ServerURI + Environment.NewLine);
        }

        /// <summary>
        /// If the server is stopped, the connection will time out after 30 seconds (default), and the 
        /// Closed event will fire.
        /// </summary>
        private void Connection_Closed()
        {
            //Deactivate chat UI; show login UI. 
            this.Invoke((Action)(() => ChatPanel.Visible = false));
            this.Invoke((Action)(() => ButtonSend.Enabled = false));
            this.Invoke((Action)(() => StatusText.Text = "You have been disconnected."));
            this.Invoke((Action)(() => SignInPanel.Visible = true));
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            UserName = UserNameTextBox.Text;
            //Connect to server (use async method to avoid blocking UI thread)
            if (!String.IsNullOrEmpty(UserName))
            {
                StatusText.Visible = true;
                StatusText.Text = "Connecting to server...";
                ConnectAsync();
            }
        }

        private void WinFormsClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Connection != null)
            {
                Connection.Stop();
                Connection.Dispose();
            }
        }

        public void SaveFolder()
        {
            DialogResult result = saveFdBrow.ShowDialog();
            if (!string.IsNullOrWhiteSpace(saveFdBrow.SelectedPath))
            {
                saveDirectory(saveFdBrow.SelectedPath);
                SaveLabel.Text = saveFdBrow.SelectedPath;
            }
        }

        public void selectFolder()
        {
            DialogResult result = monFdBrow.ShowDialog();
            if (!string.IsNullOrWhiteSpace(monFdBrow.SelectedPath))
            {
                watcherDirectory(monFdBrow.SelectedPath);
                MonLabel.Text = monFdBrow.SelectedPath;
            }
        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {
            selectFolder();   
        }
     
        private void SaveFolderBtn_Click(object sender, EventArgs e)
        {
            SaveFolder();
        }
    }
}
