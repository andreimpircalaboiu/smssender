using System;
using System.Collections.Generic;
using SmsSender.Application.GSMServices;
using SmsSender.Data;
using SmsSender.Data.DbServices;

namespace SmsSender.Application
{
    public class CoreManager
    {
        private readonly PortManagement.PortManagement _portManagement;
        private GsmService _smsService;
        private readonly QueueManager _queueManager;
        private readonly DbSentStateSetter _sentStateSetter;
        private readonly TimeManager _timeManager;
        private string _resultString = string.Empty;

        public CoreManager(PortManagement.PortManagement portManagement)
        {
            var context = new DBSMSEntities();
            _queueManager = new QueueManager
            {
                Context = context
            };
            _sentStateSetter = new DbSentStateSetter
            {
                Context = context
            };
            _timeManager = new TimeManager();
            _portManagement = portManagement;
        }

        public Queue<SMSCollection> QueuedItems { get; private set; }


        public Queue<SMSCollection> UpdateFromDatabase()
        {
            QueuedItems = _queueManager.RetrieveQueuedItems();
            return QueuedItems;
        }
        public string SendOneItem(SMSCollection sms)
        {

            try
            {
                _resultString = " ";
                _smsService = new SmsSenderService()
                {
                    PhoneNumber = sms.PhoneNumber,
                    Message = sms.MessageContent,
                    PortManagement = _portManagement
                };
                var smsSender = (SmsSenderService)_smsService;
                var now = DateTime.Now.TimeOfDay;
                if ((now <= _timeManager.StartSmsTimeSpan) || (now >= _timeManager.EndSmsTimeSpan))
                {
                    return _resultString = "Intervalul orar nu permite trimiterea de SMS-uri";
                }
                else
                {
                    if (!smsSender.Send())
                    {
                        return _resultString = "Failed to send a message";
                    }
                    else
                    {
                        if (_sentStateSetter.SetIsSentToTrue(sms))
                        {
                            return _resultString = "Message have been sent successfully";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _resultString;
        }
    }
}
