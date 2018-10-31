namespace ClientMqtt
{
    partial class LoginForm
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
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.basicTab = new System.Windows.Forms.TabControl();
            this.Basic = new System.Windows.Forms.TabPage();
            this.clientId = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.threahLabel = new System.Windows.Forms.Label();
            this.threadName = new System.Windows.Forms.TextBox();
            this.advancedTab = new System.Windows.Forms.TabPage();
            this.password = new System.Windows.Forms.TextBox();
            this.portBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.brokerAddressBox = new System.Windows.Forms.TextBox();
            this.submitData = new System.Windows.Forms.Button();
            this.infoGroupBox.SuspendLayout();
            this.basicTab.SuspendLayout();
            this.Basic.SuspendLayout();
            this.advancedTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.basicTab);
            this.infoGroupBox.Controls.Add(this.submitData);
            this.infoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(156, 226);
            this.infoGroupBox.TabIndex = 8;
            this.infoGroupBox.TabStop = false;
            // 
            // basicTab
            // 
            this.basicTab.Controls.Add(this.Basic);
            this.basicTab.Controls.Add(this.advancedTab);
            this.basicTab.Location = new System.Drawing.Point(0, 0);
            this.basicTab.Name = "basicTab";
            this.basicTab.SelectedIndex = 0;
            this.basicTab.Size = new System.Drawing.Size(157, 187);
            this.basicTab.TabIndex = 9;
            // 
            // Basic
            // 
            this.Basic.BackColor = System.Drawing.Color.Transparent;
            this.Basic.Controls.Add(this.clientId);
            this.Basic.Controls.Add(this.usernameLabel);
            this.Basic.Controls.Add(this.threahLabel);
            this.Basic.Controls.Add(this.threadName);
            this.Basic.ForeColor = System.Drawing.Color.Black;
            this.Basic.Location = new System.Drawing.Point(4, 22);
            this.Basic.Name = "Basic";
            this.Basic.Padding = new System.Windows.Forms.Padding(3);
            this.Basic.Size = new System.Drawing.Size(149, 161);
            this.Basic.TabIndex = 0;
            this.Basic.Text = "Basic";
            // 
            // clientId
            // 
            this.clientId.Location = new System.Drawing.Point(3, 19);
            this.clientId.Name = "clientId";
            this.clientId.Size = new System.Drawing.Size(142, 20);
            this.clientId.TabIndex = 13;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(0, 3);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(47, 13);
            this.usernameLabel.TabIndex = 12;
            this.usernameLabel.Text = "Client ID";
            // 
            // threahLabel
            // 
            this.threahLabel.AutoSize = true;
            this.threahLabel.Location = new System.Drawing.Point(0, 42);
            this.threahLabel.Name = "threahLabel";
            this.threahLabel.Size = new System.Drawing.Size(41, 13);
            this.threahLabel.TabIndex = 14;
            this.threahLabel.Text = "Thread";
            // 
            // threadName
            // 
            this.threadName.Location = new System.Drawing.Point(3, 58);
            this.threadName.Name = "threadName";
            this.threadName.Size = new System.Drawing.Size(142, 20);
            this.threadName.TabIndex = 15;
            // 
            // advancedTab
            // 
            this.advancedTab.BackColor = System.Drawing.Color.Transparent;
            this.advancedTab.Controls.Add(this.password);
            this.advancedTab.Controls.Add(this.portBox);
            this.advancedTab.Controls.Add(this.label2);
            this.advancedTab.Controls.Add(this.label4);
            this.advancedTab.Controls.Add(this.label1);
            this.advancedTab.Controls.Add(this.label3);
            this.advancedTab.Controls.Add(this.username);
            this.advancedTab.Controls.Add(this.brokerAddressBox);
            this.advancedTab.Location = new System.Drawing.Point(4, 22);
            this.advancedTab.Name = "advancedTab";
            this.advancedTab.Padding = new System.Windows.Forms.Padding(3);
            this.advancedTab.Size = new System.Drawing.Size(149, 161);
            this.advancedTab.TabIndex = 1;
            this.advancedTab.Text = "Advanced";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(3, 135);
            this.password.Name = "password";
            this.password.PasswordChar = '♥';
            this.password.Size = new System.Drawing.Size(142, 20);
            this.password.TabIndex = 19;
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(2, 19);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(143, 20);
            this.portBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Broker Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Username";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(3, 97);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(142, 20);
            this.username.TabIndex = 17;
            // 
            // brokerAddressBox
            // 
            this.brokerAddressBox.Location = new System.Drawing.Point(3, 58);
            this.brokerAddressBox.Name = "brokerAddressBox";
            this.brokerAddressBox.Size = new System.Drawing.Size(142, 20);
            this.brokerAddressBox.TabIndex = 10;
            // 
            // submitData
            // 
            this.submitData.Location = new System.Drawing.Point(4, 193);
            this.submitData.Name = "submitData";
            this.submitData.Size = new System.Drawing.Size(145, 26);
            this.submitData.TabIndex = 16;
            this.submitData.Text = "Submit";
            this.submitData.UseVisualStyleBackColor = true;
            this.submitData.Click += new System.EventHandler(this.SubmitData_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.submitData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 245);
            this.Controls.Add(this.infoGroupBox);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.TopMost = true;
            this.infoGroupBox.ResumeLayout(false);
            this.basicTab.ResumeLayout(false);
            this.Basic.ResumeLayout(false);
            this.Basic.PerformLayout();
            this.advancedTab.ResumeLayout(false);
            this.advancedTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox brokerAddressBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox clientId;
        private System.Windows.Forms.TextBox threadName;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label threahLabel;
        private System.Windows.Forms.Button submitData;
        private System.Windows.Forms.TabControl basicTab;
        private System.Windows.Forms.TabPage Basic;
        private System.Windows.Forms.TabPage advancedTab;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
    }
}