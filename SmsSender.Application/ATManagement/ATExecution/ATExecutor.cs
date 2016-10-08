using System;
using System.IO.Ports;
using System.Threading;

namespace SmsSender.Application.ATManagement.ATExecution
{
    public abstract class ATExecutor
    {
        private AutoResetEvent _receiveNow;
        private SerialPort _port;
        public AutoResetEvent ReceiveNow
        {
            get { return _receiveNow; }
            set
            {
                if (value == null) throw new ArgumentNullException("receiveNow");
                _receiveNow = value;
            }
        }

        public SerialPort Port
        {
            get { return _port; }
            set
            {
                if (value == null) throw new ArgumentNullException("port");
                _port = value;
            }
        }
        protected abstract string ReadResponse(int timeout);
        public abstract string Execute(string command, int responseTimeout);
    }
}
