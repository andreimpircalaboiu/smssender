using System;

namespace SmsSender.Application.GSMServices
{
    public class TimeManager
    {
        public TimeManager()
        {
            StartSmsTimeSpan = new TimeSpan(8, 0, 0);
            EndSmsTimeSpan = new TimeSpan(20, 0, 0);
        }

        public TimeSpan StartSmsTimeSpan { get; private set; }
        public TimeSpan EndSmsTimeSpan { get; private set; }

 
    }
}
