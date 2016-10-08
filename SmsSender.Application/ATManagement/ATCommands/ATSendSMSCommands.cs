namespace SmsSender.Application.ATManagement.ATCommands
{
    public class ATSendSMSCommands : ATCommands
    {
        public const string FirstCommand = "AT";
        public const string SecondCommand = "AT+CMGF=1";
        private readonly string _thirdCommand = "AT+CMGS=\"";

        public string ThirdCommand
        {
            get
            {
                return _thirdCommand + PhoneNumber + "\"";
            }
        }
        public string FourthCommand
        {
            get
            {
                return Message + char.ConvertFromUtf32(26) + "\r";
            }
        }
    }
}
