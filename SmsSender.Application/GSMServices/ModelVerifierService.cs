using System;
using SmsSender.Application.ATManagement.ATCommands;
using SmsSender.Application.ATManagement.ATExecution;

namespace SmsSender.Application.GSMServices
{
    public class ModelVerifierService : GsmService
    {
        private readonly string _model;
        protected override void ATCommandsInit()
        {
            UsableAtCommands = new ATGetPortCommands()
            {
                Message = Message,
                PhoneNumber = PhoneNumber,
            };
        }
        protected override void ATExecutorInit()
        {
            PrimaryAtExecutor = new ATPortFinderExecutor()
               {
                   ReceiveNow = PortManagement.ReceiveNow,
                   Port = PortManagement.Port
               };
        }
        public ModelVerifierService(string model)
        {
            this._model = model;
        }
        public bool IsMyGsmDevice()
        {
            ATCommandsInit();
            ATExecutorInit();
            try
            {

                var recievedData = PrimaryAtExecutor.Execute(ATGetPortCommands.GetDeviceNameCommand, 500);
                var isDesiredDevice = recievedData.Contains(_model);
                return isDesiredDevice;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }     
    }
}
