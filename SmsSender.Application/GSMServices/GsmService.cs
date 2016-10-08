using System;
using SmsSender.Application.ATManagement.ATCommands;
using SmsSender.Application.ATManagement.ATExecution;

namespace SmsSender.Application.GSMServices
{
    public abstract class GsmService
    {
        protected ATExecutor PrimaryAtExecutor;
        protected ATCommands UsableAtCommands;
        private PortManagement.PortManagement _portManagement;
        public PortManagement.PortManagement PortManagement
        {
            get { return _portManagement; }
            set
            {
                if (value == null) throw new ArgumentNullException("portManagement");
                _portManagement = value;
            }
        }
        public string PhoneNumber { get; set; }

        public string Message { get; set; }

        protected abstract void ATExecutorInit();
        protected abstract void ATCommandsInit();

    }
}
