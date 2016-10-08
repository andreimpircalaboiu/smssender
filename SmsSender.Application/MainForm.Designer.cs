namespace SmsSender.Application
{
    partial class MainForm
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
            this.TabSendSMS = new System.Windows.Forms.TabPage();
            this.gboSendSMS = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.ConnectToPortBut = new System.Windows.Forms.Button();
            this.TabSMSViaUSBApp = new System.Windows.Forms.TabControl();
            this.gboConnectionStatus = new System.Windows.Forms.GroupBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.DisconnectFromPortBut = new System.Windows.Forms.Button();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.TabSendSMS.SuspendLayout();
            this.gboSendSMS.SuspendLayout();
            this.TabSMSViaUSBApp.SuspendLayout();
            this.gboConnectionStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabSendSMS
            // 
            this.TabSendSMS.Controls.Add(this.gboSendSMS);
            this.TabSendSMS.Location = new System.Drawing.Point(4, 22);
            this.TabSendSMS.Name = "TabSendSMS";
            this.TabSendSMS.Padding = new System.Windows.Forms.Padding(3);
            this.TabSendSMS.Size = new System.Drawing.Size(382, 263);
            this.TabSendSMS.TabIndex = 1;
            this.TabSendSMS.Text = "Send SMS";
            this.TabSendSMS.UseVisualStyleBackColor = true;
            // 
            // gboSendSMS
            // 
            this.gboSendSMS.Controls.Add(this.label8);
            this.gboSendSMS.Controls.Add(this.label9);
            this.gboSendSMS.Controls.Add(this.PhoneNumberTextBox);
            this.gboSendSMS.Controls.Add(this.MessageTextBox);
            this.gboSendSMS.Location = new System.Drawing.Point(20, 6);
            this.gboSendSMS.Name = "gboSendSMS";
            this.gboSendSMS.Size = new System.Drawing.Size(346, 251);
            this.gboSendSMS.TabIndex = 43;
            this.gboSendSMS.TabStop = false;
            this.gboSendSMS.Text = "Send SMS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Message";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Number";
            this.label9.Visible = false;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(9, 42);
            this.PhoneNumberTextBox.MaxLength = 15;
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(323, 20);
            this.PhoneNumberTextBox.TabIndex = 41;
            this.PhoneNumberTextBox.Visible = false;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(9, 81);
            this.MessageTextBox.MaxLength = 160;
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(323, 134);
            this.MessageTextBox.TabIndex = 39;
            this.MessageTextBox.Visible = false;
            // 
            // ConnectToPortBut
            // 
            this.ConnectToPortBut.Location = new System.Drawing.Point(224, 19);
            this.ConnectToPortBut.Name = "ConnectToPortBut";
            this.ConnectToPortBut.Size = new System.Drawing.Size(75, 25);
            this.ConnectToPortBut.TabIndex = 14;
            this.ConnectToPortBut.Text = "Connect";
            this.ConnectToPortBut.UseVisualStyleBackColor = true;
            this.ConnectToPortBut.Click += new System.EventHandler(this.ConnectToPortBut_Click);
            // 
            // TabSMSViaUSBApp
            // 
            this.TabSMSViaUSBApp.Controls.Add(this.TabSendSMS);
            this.TabSMSViaUSBApp.Location = new System.Drawing.Point(12, 12);
            this.TabSMSViaUSBApp.Name = "TabSMSViaUSBApp";
            this.TabSMSViaUSBApp.SelectedIndex = 0;
            this.TabSMSViaUSBApp.Size = new System.Drawing.Size(390, 289);
            this.TabSMSViaUSBApp.TabIndex = 16;
            this.TabSMSViaUSBApp.Visible = false;
            // 
            // gboConnectionStatus
            // 
            this.gboConnectionStatus.BackColor = System.Drawing.Color.Transparent;
            this.gboConnectionStatus.Controls.Add(this.ConnectToPortBut);
            this.gboConnectionStatus.Controls.Add(this.lblConnectionStatus);
            this.gboConnectionStatus.Controls.Add(this.DisconnectFromPortBut);
            this.gboConnectionStatus.Location = new System.Drawing.Point(12, 303);
            this.gboConnectionStatus.Name = "gboConnectionStatus";
            this.gboConnectionStatus.Size = new System.Drawing.Size(386, 56);
            this.gboConnectionStatus.TabIndex = 42;
            this.gboConnectionStatus.TabStop = false;
            this.gboConnectionStatus.Text = "Connection Status";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionStatus.Location = new System.Drawing.Point(18, 25);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(79, 13);
            this.lblConnectionStatus.TabIndex = 36;
            this.lblConnectionStatus.Text = "Not Connected";
            // 
            // DisconnectFromPortBut
            // 
            this.DisconnectFromPortBut.Enabled = false;
            this.DisconnectFromPortBut.Location = new System.Drawing.Point(305, 19);
            this.DisconnectFromPortBut.Name = "DisconnectFromPortBut";
            this.DisconnectFromPortBut.Size = new System.Drawing.Size(75, 25);
            this.DisconnectFromPortBut.TabIndex = 4;
            this.DisconnectFromPortBut.Text = "Disconnect";
            this.DisconnectFromPortBut.Click += new System.EventHandler(this.DisconnectFromPortBut_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.statusBar1.Location = new System.Drawing.Point(0, 365);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(419, 20);
            this.statusBar1.TabIndex = 76;
            this.statusBar1.Text = "Message";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 385);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.gboConnectionStatus);
            this.Controls.Add(this.TabSMSViaUSBApp);
            this.Name = "MainForm";
            this.Text = "SMSViaUSBApp";
            this.TabSendSMS.ResumeLayout(false);
            this.gboSendSMS.ResumeLayout(false);
            this.gboSendSMS.PerformLayout();
            this.TabSMSViaUSBApp.ResumeLayout(false);
            this.gboConnectionStatus.ResumeLayout(false);
            this.gboConnectionStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage TabSendSMS;
        private System.Windows.Forms.GroupBox gboSendSMS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button ConnectToPortBut;
        private System.Windows.Forms.TabControl TabSMSViaUSBApp;
        private System.Windows.Forms.GroupBox gboConnectionStatus;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Button DisconnectFromPortBut;
        private System.Windows.Forms.StatusBar statusBar1;
    }
}

