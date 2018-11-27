namespace SignalRChat
{
    partial class WinFormsServer
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
            this.components = new System.ComponentModel.Container();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.RichTextBoxConsole = new System.Windows.Forms.RichTextBox();
            this.dataBasesDataSet = new SignalRChat.DataBasesDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new SignalRChat.DataBasesDataSetTableAdapters.Table12TableAdapter();
            this.tableAdapterManager = new SignalRChat.DataBasesDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataBasesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(13, 13);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(110, 23);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Enabled = false;
            this.ButtonStop.Location = new System.Drawing.Point(205, 13);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(110, 23);
            this.ButtonStop.TabIndex = 0;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // RichTextBoxConsole
            // 
            this.RichTextBoxConsole.Location = new System.Drawing.Point(13, 42);
            this.RichTextBoxConsole.Name = "RichTextBoxConsole";
            this.RichTextBoxConsole.ReadOnly = true;
            this.RichTextBoxConsole.Size = new System.Drawing.Size(302, 226);
            this.RichTextBoxConsole.TabIndex = 1;
            this.RichTextBoxConsole.Text = "";
            // 
            // dataBasesDataSet
            // 
            this.dataBasesDataSet.DataSetName = "DataBasesDataSet";
            this.dataBasesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table12";
            this.tableBindingSource.DataSource = this.dataBasesDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table12TableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = SignalRChat.DataBasesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // WinFormsServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 288);
            this.Controls.Add(this.RichTextBoxConsole);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WinFormsServer";
            this.Text = "WinForms SignalR Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WinFormsServer_FormClosing);
            this.Load += new System.EventHandler(this.WinFormsServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBasesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.RichTextBox RichTextBoxConsole;
        private DataBasesDataSet dataBasesDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DataBasesDataSetTableAdapters.Table12TableAdapter tableTableAdapter;
        private DataBasesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

