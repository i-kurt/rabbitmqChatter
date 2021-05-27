
namespace rabbitmqChatter
{
    partial class frmChatter
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
            this.lblName = new System.Windows.Forms.Label();
            this.cmbNames = new System.Windows.Forms.ComboBox();
            this.btnSucscribe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtVirtualHost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUnSubscribe = new System.Windows.Forms.Button();
            this.cmbRoutingKey = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // cmbNames
            // 
            this.cmbNames.FormattingEnabled = true;
            this.cmbNames.Items.AddRange(new object[] {
            "Chatter1",
            "Chatter2"});
            this.cmbNames.Location = new System.Drawing.Point(69, 13);
            this.cmbNames.Name = "cmbNames";
            this.cmbNames.Size = new System.Drawing.Size(248, 24);
            this.cmbNames.TabIndex = 0;
            this.cmbNames.Text = "Chatter1";
            // 
            // btnSucscribe
            // 
            this.btnSucscribe.Location = new System.Drawing.Point(69, 71);
            this.btnSucscribe.Name = "btnSucscribe";
            this.btnSucscribe.Size = new System.Drawing.Size(106, 28);
            this.btnSucscribe.TabIndex = 3;
            this.btnSucscribe.Text = "Subscribe";
            this.btnSucscribe.UseVisualStyleBackColor = true;
            this.btnSucscribe.Click += new System.EventHandler(this.btnSucscribe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Message:";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(79, 115);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(409, 22);
            this.txtMsg.TabIndex = 5;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(79, 144);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(714, 284);
            this.txtStatus.TabIndex = 7;
            this.txtStatus.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(687, 111);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(106, 28);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(411, 13);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(189, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // txtVirtualHost
            // 
            this.txtVirtualHost.Location = new System.Drawing.Point(69, 43);
            this.txtVirtualHost.Name = "txtVirtualHost";
            this.txtVirtualHost.Size = new System.Drawing.Size(189, 22);
            this.txtVirtualHost.TabIndex = 2;
            this.txtVirtualHost.Text = "Chat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "VHost:";
            // 
            // btnUnSubscribe
            // 
            this.btnUnSubscribe.Enabled = false;
            this.btnUnSubscribe.Location = new System.Drawing.Point(190, 71);
            this.btnUnSubscribe.Name = "btnUnSubscribe";
            this.btnUnSubscribe.Size = new System.Drawing.Size(106, 28);
            this.btnUnSubscribe.TabIndex = 4;
            this.btnUnSubscribe.Text = "UnSubscribe";
            this.btnUnSubscribe.UseVisualStyleBackColor = true;
            this.btnUnSubscribe.Click += new System.EventHandler(this.btnUnSubscribe_Click);
            // 
            // cmbRoutingKey
            // 
            this.cmbRoutingKey.FormattingEnabled = true;
            this.cmbRoutingKey.Items.AddRange(new object[] {
            "Country.Turkey.Ankara",
            "Country.Turkey.Adana"});
            this.cmbRoutingKey.Location = new System.Drawing.Point(494, 114);
            this.cmbRoutingKey.Name = "cmbRoutingKey";
            this.cmbRoutingKey.Size = new System.Drawing.Size(187, 24);
            this.cmbRoutingKey.TabIndex = 10;
            this.cmbRoutingKey.Text = "Country.Turkey.Adana";
            // 
            // frmChatter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 442);
            this.Controls.Add(this.cmbRoutingKey);
            this.Controls.Add(this.btnUnSubscribe);
            this.Controls.Add(this.txtVirtualHost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSucscribe);
            this.Controls.Add(this.cmbNames);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChatter";
            this.Text = "Chatter";
            this.Load += new System.EventHandler(this.frmChatter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbNames;
        private System.Windows.Forms.Button btnSucscribe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.RichTextBox txtStatus;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtVirtualHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUnSubscribe;
        private System.Windows.Forms.ComboBox cmbRoutingKey;
    }
}