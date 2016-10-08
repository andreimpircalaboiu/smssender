using System.Collections.Generic;
using System.Linq;
using SmsSender.Data;
using SmsSender.Data.DbServices;

namespace SmsSender.Application.GSMServices
{
    public class QueueManager
    {
        private MessageQueries _messageQuery;
        private readonly Queue<SMSCollection> _messageHighPriorityQueue;
        private readonly Queue<SMSCollection> _messageMediumPriorityQueue;
        private readonly Queue<SMSCollection> _messageLowPriorityQueue;
        private IList<SMSCollection> _messageCollection;

        public DBSMSEntities Context { get; set; }

        public QueueManager()
        {

            _messageHighPriorityQueue = new Queue<SMSCollection>(1000);
            _messageMediumPriorityQueue = new Queue<SMSCollection>(1000);
            _messageLowPriorityQueue = new Queue<SMSCollection>(1000);
        }

        public Queue<SMSCollection> RetrieveQueuedItems()
        {
            _messageQuery = new MessageQueries()
            {
                Context = Context
            };
            _messageCollection = _messageQuery.RetrieveItems("false");
            foreach (var smsItem in _messageCollection.Where(smsItem => smsItem.Priority == 0))
            {
                _messageHighPriorityQueue.Enqueue(smsItem);
            }
            if (_messageHighPriorityQueue.Count != 0)
            {
                return _messageHighPriorityQueue;
            }
            foreach (var smsItem in _messageCollection.Where(smsItem => smsItem.Priority == 1))
            {
                _messageMediumPriorityQueue.Enqueue(smsItem);
            }
            if (_messageMediumPriorityQueue.Count != 0)
            {
                return _messageMediumPriorityQueue;
            }
            foreach (var smsItem in _messageCollection.Where(smsItem => smsItem.Priority == 2))
            {
                _messageLowPriorityQueue.Enqueue(smsItem);
            }
            return _messageLowPriorityQueue;
        }
    }
}
