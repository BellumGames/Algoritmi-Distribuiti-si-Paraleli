﻿namespace L4Client
{
    partial class Client
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.listViewChat = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(139, 415);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(568, 23);
            this.textBoxMessage.TabIndex = 1;
            this.textBoxMessage.Text = "Here your message...";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(713, 414);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // listViewChat
            // 
            this.listViewChat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.listViewChat.Location = new System.Drawing.Point(139, 12);
            this.listViewChat.Name = "listViewChat";
            this.listViewChat.Size = new System.Drawing.Size(649, 397);
            this.listViewChat.TabIndex = 3;
            this.listViewChat.UseCompatibleStateImageBehavior = false;
            this.listViewChat.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Welcome to Chat";
            this.columnHeader5.Width = 625;
            // 
            // listBoxClients
            // 
            this.listBoxClients.ItemHeight = 15;
            this.listBoxClients.Location = new System.Drawing.Point(12, 12);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(121, 424);
            this.listBoxClients.TabIndex = 0;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxClients);
            this.Controls.Add(this.listViewChat);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textBoxMessage);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxMessage;
        private Button btnSend;
        private ListView listViewChat;
        private ColumnHeader columnHeader5;
        private ListBox listBoxClients;
    }
}