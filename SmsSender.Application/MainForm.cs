using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmsSender.Application.PortManagement;
using SmsSender.Application.Properties;
using SmsSender.Data;

namespace SmsSender.Application
{
    public partial class MainForm : Form
    {
        private PortManagement.PortManagement _portManagement;
        private CoreManager _coreManager;
        private Queue<SMSCollection> _messagesToBeSent;
        private System.Threading.Timer _timer;
     
        public MainForm()
        {
            InitializeComponent();
            this.TabSMSViaUSBApp.Visible = false;
            this.DisconnectFromPortBut.Enabled = false;
            
        }

        private delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            if (statusBar1.InvokeRequired)
            {
                var d = new SetTextCallback(SetText);
                Invoke(d, text);
            }
            else
            {
                statusBar1.Text = text;
            }
    
        }
        private static async void Wait2000()
        {
            await Task.Delay(2000);
        }
        private void GrabAndSendFunction()
        {
            var tempTimer = 0;
            while ((_messagesToBeSent == null || _messagesToBeSent.Count == 0) && (tempTimer<4))
            {
                Wait2000();
                _messagesToBeSent = _coreManager.UpdateFromDatabase();
                foreach (var tempString in _messagesToBeSent.Select(sms => _coreManager.SendOneItem(sms)))
                {
                    SetText(tempString);
                }
                _messagesToBeSent.Clear();
                tempTimer++;
            }
        }
        private void ConnectToPortBut_Click(object sender, EventArgs e)
        {
            try
            {
                var autoDetectPort = new AutoDetectGsmPort();
                if (autoDetectPort.IsNeededPort())
                {
                    this.statusBar1.Text = Resources.MainForm_ConnectToPortBut_Click_Modem_is_connected_at_PORT_ + autoDetectPort.DesiredPortManagement.Port.PortName;
                    this.lblConnectionStatus.Text = Resources.MainForm_ConnectToPortBut_Click_Connected_at_ + autoDetectPort.DesiredPortManagement.Port.PortName;
                    this.DisconnectFromPortBut.Enabled = true;
                    this.ConnectToPortBut.Enabled = false;
                    _portManagement = autoDetectPort.DesiredPortManagement;
                    _coreManager = new CoreManager(_portManagement);
                    _timer = new System.Threading.Timer(s => GrabAndSendFunction(), null, TimeSpan.Zero, TimeSpan.FromMinutes(1));
                }
                else
                {
                    this.statusBar1.Text = Resources.MainForm_ConnectToPortBut_Click_Invalid_port_settings;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DisconnectFromPortBut_Click(object sender, EventArgs e)
        {
            try
            {
                _portManagement.ClosePort();
                this.lblConnectionStatus.Text = Resources.MainForm_DisconnectFromPortBut_Click_Not_Connected;
                this.DisconnectFromPortBut.Enabled = false;
                this.statusBar1.Text = "";
                this.ConnectToPortBut.Enabled = true;
                _timer.Dispose();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
