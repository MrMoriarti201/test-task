namespace WinFormsClient
{
    partial class WinFormsClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonSend = new System.Windows.Forms.Button();
            this.TextBoxMessage = new System.Windows.Forms.TextBox();
            this.RichTextBoxConsole = new System.Windows.Forms.RichTextBox();
            this.ChatPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MonLabel = new System.Windows.Forms.Label();
            this.monitoringFolder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.SaveFolderBtn = new System.Windows.Forms.Button();
            this.SignInPanel = new System.Windows.Forms.Panel();
            this.StatusText = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ChatPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SignInPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSend
            // 
            this.ButtonSend.Enabled = false;
            this.ButtonSend.Location = new System.Drawing.Point(414, 10);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(75, 23);
            this.ButtonSend.TabIndex = 1;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Location = new System.Drawing.Point(8, 12);
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.Size = new System.Drawing.Size(400, 20);
            this.TextBoxMessage.TabIndex = 2;
            // 
            // RichTextBoxConsole
            // 
            this.RichTextBoxConsole.Location = new System.Drawing.Point(8, 113);
            this.RichTextBoxConsole.Name = "RichTextBoxConsole";
            this.RichTextBoxConsole.ReadOnly = true;
            this.RichTextBoxConsole.Size = new System.Drawing.Size(481, 386);
            this.RichTextBoxConsole.TabIndex = 3;
            this.RichTextBoxConsole.Text = "";
            // 
            // ChatPanel
            // 
            this.ChatPanel.Controls.Add(this.panel2);
            this.ChatPanel.Controls.Add(this.panel1);
            this.ChatPanel.Controls.Add(this.RichTextBoxConsole);
            this.ChatPanel.Controls.Add(this.TextBoxMessage);
            this.ChatPanel.Controls.Add(this.ButtonSend);
            this.ChatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChatPanel.Location = new System.Drawing.Point(0, 0);
            this.ChatPanel.Name = "ChatPanel";
            this.ChatPanel.Size = new System.Drawing.Size(501, 513);
            this.ChatPanel.TabIndex = 4;
            this.ChatPanel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MonLabel);
            this.panel2.Controls.Add(this.monitoringFolder);
            this.panel2.Location = new System.Drawing.Point(12, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 33);
            this.panel2.TabIndex = 9;
            // 
            // MonLabel
            // 
            this.MonLabel.AutoSize = true;
            this.MonLabel.Location = new System.Drawing.Point(163, 12);
            this.MonLabel.Name = "MonLabel";
            this.MonLabel.Size = new System.Drawing.Size(190, 13);
            this.MonLabel.TabIndex = 5;
            this.MonLabel.Text = "Выберите директорию мониторинга";
            // 
            // monitoringFolder
            // 
            this.monitoringFolder.Location = new System.Drawing.Point(3, 7);
            this.monitoringFolder.Name = "monitoringFolder";
            this.monitoringFolder.Size = new System.Drawing.Size(154, 23);
            this.monitoringFolder.TabIndex = 4;
            this.monitoringFolder.Text = "Директория мониторинга";
            this.monitoringFolder.UseVisualStyleBackColor = true;
            this.monitoringFolder.Click += new System.EventHandler(this.SelectFolder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveLabel);
            this.panel1.Controls.Add(this.SaveFolderBtn);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 32);
            this.panel1.TabIndex = 8;
            // 
            // SaveLabel
            // 
            this.SaveLabel.AutoSize = true;
            this.SaveLabel.Location = new System.Drawing.Point(163, 12);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(183, 13);
            this.SaveLabel.TabIndex = 7;
            this.SaveLabel.Text = "Выберите директорию сохранения";
            // 
            // SaveFolderBtn
            // 
            this.SaveFolderBtn.Location = new System.Drawing.Point(3, 7);
            this.SaveFolderBtn.Name = "SaveFolderBtn";
            this.SaveFolderBtn.Size = new System.Drawing.Size(154, 23);
            this.SaveFolderBtn.TabIndex = 6;
            this.SaveFolderBtn.Text = "Директория сохранения";
            this.SaveFolderBtn.UseVisualStyleBackColor = true;
            this.SaveFolderBtn.Click += new System.EventHandler(this.SaveFolderBtn_Click);
            // 
            // SignInPanel
            // 
            this.SignInPanel.Controls.Add(this.StatusText);
            this.SignInPanel.Controls.Add(this.SignInButton);
            this.SignInPanel.Controls.Add(this.UserNameTextBox);
            this.SignInPanel.Controls.Add(this.label1);
            this.SignInPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignInPanel.Location = new System.Drawing.Point(0, 0);
            this.SignInPanel.Name = "SignInPanel";
            this.SignInPanel.Size = new System.Drawing.Size(501, 513);
            this.SignInPanel.TabIndex = 4;
            // 
            // StatusText
            // 
            this.StatusText.Location = new System.Drawing.Point(12, 59);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(477, 13);
            this.StatusText.TabIndex = 6;
            this.StatusText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StatusText.Visible = false;
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(414, 22);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(75, 23);
            this.SignInButton.TabIndex = 5;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(7, 24);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(401, 20);
            this.UserNameTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter user name:";
            // 
            // WinFormsClient
            // 
            this.AcceptButton = this.ButtonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 513);
            this.Controls.Add(this.ChatPanel);
            this.Controls.Add(this.SignInPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(517, 552);
            this.Name = "WinFormsClient";
            this.Text = "WinForms SignalR Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WinFormsClient_FormClosing);
            this.ChatPanel.ResumeLayout(false);
            this.ChatPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SignInPanel.ResumeLayout(false);
            this.SignInPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.TextBox TextBoxMessage;
        private System.Windows.Forms.RichTextBox RichTextBoxConsole;
        private System.Windows.Forms.Panel ChatPanel;
        private System.Windows.Forms.Panel SignInPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button monitoringFolder;
        private System.Windows.Forms.Label MonLabel;
        private System.Windows.Forms.Button SaveFolderBtn;
        private System.Windows.Forms.Label SaveLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

