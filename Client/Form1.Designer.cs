namespace Client
{
    partial class Form1
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
            this.listBoxMessage = new System.Windows.Forms.ListBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMessage
            // 
            this.listBoxMessage.FormattingEnabled = true;
            this.listBoxMessage.Location = new System.Drawing.Point(138, 11);
            this.listBoxMessage.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxMessage.Name = "listBoxMessage";
            this.listBoxMessage.Size = new System.Drawing.Size(461, 264);
            this.listBoxMessage.TabIndex = 2;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(138, 279);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(371, 20);
            this.textBoxMessage.TabIndex = 3;
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Location = new System.Drawing.Point(513, 279);
            this.buttonSendMessage.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(86, 19);
            this.buttonSendMessage.TabIndex = 4;
            this.buttonSendMessage.Text = "SendMessage";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(11, 11);
            this.listBoxUsers.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(123, 264);
            this.listBoxUsers.TabIndex = 5;
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(11, 279);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(122, 20);
            this.buttonDisconnect.TabIndex = 6;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 301);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.buttonSendMessage);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.listBoxMessage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListBox listBoxMessage;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonSendMessage;
        public System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Button buttonDisconnect;
    }
}

