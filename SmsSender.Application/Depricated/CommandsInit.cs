using System;
using SmsSender.Application.GSMServices;

namespace SmsSender.Application.Depricated
{
    public class CommandsInit
    {
        private CommandFactory _factory;
        private PortManagement.PortManagement _portManager;

        public PortManagement.PortManagement PortManager
        {
            get { return _portManager; }
            set
            {
                if (value == null) throw new ArgumentNullException("portManager");
                _portManager = value;
            }
        }
        
        public CommandFactory CommandFactory
        {
            get { return _factory; }
            set { if (value == null) throw new ArgumentNullException("commandFactory");
            _factory = value;
            }
        }
        public GsmService SmsService { get; set; }
    }
}
