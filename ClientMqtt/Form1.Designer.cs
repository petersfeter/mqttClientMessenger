namespace ClientMqtt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.logins = new System.Windows.Forms.GroupBox();
            this.usersListOnline = new System.Windows.Forms.ListView();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.logins.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.outputText);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Messages";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(0, 0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(10, 10);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Visible = false;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.Color.AliceBlue;
            this.outputText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.outputText.Location = new System.Drawing.Point(3, 22);
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(613, 382);
            this.outputText.TabIndex = 0;
            this.outputText.Text = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(10, 418);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(613, 20);
            this.txtMsg.TabIndex = 1;
            this.txtMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtMsg_KeyDown);
            // 
            // logins
            // 
            this.logins.Controls.Add(this.usersListOnline);
            this.logins.Location = new System.Drawing.Point(631, 5);
            this.logins.Name = "logins";
            this.logins.Size = new System.Drawing.Size(157, 407);
            this.logins.TabIndex = 2;
            this.logins.TabStop = false;
            this.logins.Text = "Connected Users";
            // 
            // usersListOnline
            // 
            this.usersListOnline.BackColor = System.Drawing.Color.Cornsilk;
            this.usersListOnline.GridLines = true;
            this.usersListOnline.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.usersListOnline.Location = new System.Drawing.Point(6, 19);
            this.usersListOnline.Name = "usersListOnline";
            this.usersListOnline.Size = new System.Drawing.Size(145, 382);
            this.usersListOnline.TabIndex = 0;
            this.usersListOnline.UseCompatibleStateImageBehavior = false;
            this.usersListOnline.ItemActivate += new System.EventHandler(this.UsersListOnline_ItemActivate);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(631, 418);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 20);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Logout";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.logins);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Super Uber Messenger co działa jak chce ale daje rade";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.logins.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.GroupBox logins;
        private System.Windows.Forms.ListView usersListOnline;
        private System.Windows.Forms.Button exitButton;
    }
}

