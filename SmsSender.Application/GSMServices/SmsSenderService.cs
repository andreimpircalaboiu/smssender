using System;
using SmsSender.Application.ATManagement.ATCommands;
using SmsSender.Application.ATManagement.ATExecution;

namespace SmsSender.Application.GSMServices
{
    public class SmsSenderService : GsmService
    {
        private ATSendSMSCommands _commands;
      
        protected override void ATCommandsInit()
        {
            UsableAtCommands = new ATSendSMSCommands()
            {
                Message = Message,
                PhoneNumber = PhoneNumber,
            };
        }
        protected override void ATExecutorInit()
        {
            PrimaryAtExecutor = new ATSMSExecutor()
            {
                ReceiveNow = PortManagement.ReceiveNow,
                Port = PortManagement.Port
            };
        }
        public bool Send()
        {
            ATCommandsInit();
            ATExecutorInit();
            _commands = (ATSendSMSCommands)UsableAtCommands;
            var isSent = false;

            try
            {

                var recievedData = PrimaryAtExecutor.Execute(ATSendSMSCommands.SecondCommand, 800);
              
                recievedData = PrimaryAtExecutor.Execute(_commands.ThirdCommand, 800);
              
                recievedData = PrimaryAtExecutor.Execute(_commands.FourthCommand, 2000); 
                
                if (recievedData.EndsWith("\r\nOK\r\n"))
                {
                    isSent = true;
                }
                return isSent;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }     
    }
}
