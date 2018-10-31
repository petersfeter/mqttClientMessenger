namespace ClientMqtt
{
    partial class PrivMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivMessage));
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.msgUsername = new System.Windows.Forms.Label();
            this.privMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.Color.AliceBlue;
            this.outputText.Location = new System.Drawing.Point(12, 25);
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(422, 343);
            this.outputText.TabIndex = 1;
            this.outputText.Text = "";
            // 
            // msgUsername
            // 
            this.msgUsername.AutoSize = true;
            this.msgUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.msgUsername.Location = new System.Drawing.Point(12, 5);
            this.msgUsername.Name = "msgUsername";
            this.msgUsername.Size = new System.Drawing.Size(87, 17);
            this.msgUsername.TabIndex = 2;
            this.msgUsername.Text = "<username>";
            // 
            // privMsg
            // 
            this.privMsg.Location = new System.Drawing.Point(12, 385);
            this.privMsg.Name = "privMsg";
            this.privMsg.Size = new System.Drawing.Size(422, 20);
            this.privMsg.TabIndex = 3;
            this.privMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // PrivMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(446, 417);
            this.Controls.Add(this.privMsg);
            this.Controls.Add(this.msgUsername);
            this.Controls.Add(this.outputText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrivMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Message";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrivMessage_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.Label msgUsername;
        private System.Windows.Forms.TextBox privMsg;
    }
}