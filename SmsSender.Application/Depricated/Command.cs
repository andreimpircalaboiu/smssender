using System;

namespace SmsSender.Application.Depricated
{
    public class Command
    {
        public Command(Action execute)
        {
            Execute = execute;
        }
        public Action Execute { get; protected set; }
    }
}
