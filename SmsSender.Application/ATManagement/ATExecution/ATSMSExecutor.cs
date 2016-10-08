using System;
using System.Threading.Tasks;

namespace SmsSender.Application.ATManagement.ATExecution
{
    public class ATSMSExecutor : ATExecutor
    {
        public override string Execute(string command, int responseTimeout)
        {
            try
            {

                Port.DiscardOutBuffer();
                Port.DiscardInBuffer();
                ReceiveNow.Reset();
                Port.Write(command + "\r");

                var input = ReadResponse(responseTimeout);
                if ((input.Length == 0) || ((!input.EndsWith("\r\n> ")) && (!input.EndsWith("\r\nOK\r\n"))))
                {
                    throw new ApplicationException("No success message was received.");
                }
                return input;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static async void Wait300()
        {
            await Task.Delay(300);
        }

        protected override string ReadResponse(int timeout)
        {
            var buffer = string.Empty;
            try
            {
                do
                {
                    Wait300();
                    var t = Port.ReadExisting();
                    buffer += t;

                }
                while (!buffer.EndsWith("\r\nOK\r\n") && !buffer.EndsWith("\r\n> ") && !buffer.EndsWith("\r\nERROR\r\n"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return buffer;
        }
    }
}
