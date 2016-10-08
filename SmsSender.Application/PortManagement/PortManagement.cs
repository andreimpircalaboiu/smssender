using System;
using System.IO.Ports;
using System.Text;
using System.Threading;

namespace SmsSender.Application.PortManagement
{
    public class PortManagement
    {
        private SerialPort port;

        public SerialPort Port
        {
            get { return port; }
        }
        public string PortName { get; set; }
        public int BaudRate { get; set; }
        public int DataBits { get; set; }
        public int ReadTimeout { get; set; }
        public int WriteTimeout { get; set; }
        public AutoResetEvent ReceiveNow { get; private set; }

        public void OpenPort()
        {
            ReceiveNow = new AutoResetEvent(false);
            port = new SerialPort();

            try
            {
                port.PortName = this.PortName;                                                  //COM1
                port.BaudRate = this.BaudRate;                                                  //9600
                port.DataBits = this.DataBits;                                                  //8
                port.StopBits = StopBits.One;                                                   //1
                port.Parity = Parity.None;                                                      //None
                port.ReadTimeout = this.ReadTimeout;                                            //300
                port.WriteTimeout = this.WriteTimeout;                                          //300
                port.Encoding = Encoding.GetEncoding("iso-8859-1");
                port.DataReceived += new SerialDataReceivedEventHandler(portDataReceivedEvent);
                port.Open();
                port.DtrEnable = true;
                port.RtsEnable = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Close Port
        public void ClosePort()
        {
            try
            {
                port.Close();
                port.DataReceived -= new SerialDataReceivedEventHandler(portDataReceivedEvent);
                port = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void portDataReceivedEvent(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (e.EventType == SerialData.Chars)
                {
                    ReceiveNow.Set();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
