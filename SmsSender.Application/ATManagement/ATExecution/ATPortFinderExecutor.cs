using System;

namespace SmsSender.Application.ATManagement.ATExecution
{
    public class ATPortFinderExecutor : ATExecutor
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
                return input;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        protected override string ReadResponse(int timeout)
        {
            var buffer = string.Empty;
            try
            {
                do
                {
                    if (ReceiveNow.WaitOne(timeout, false))
                    {
                        var t = Port.ReadExisting();
                        buffer += t;
                    }
                    else
                    {
                        break;
                    }
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
