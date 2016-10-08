using System;
using System.Linq;
using SmsSender.Data;
using SmsSender.Data.DbServices;

namespace SmsSender.Service
{
    public class CrudManager
    {
        private readonly UserQueries _userQueries;
        private readonly DBSMSEntities _context;
        private int _priorityNumber;
        public CrudManager()
        {
            
            _context = new DBSMSEntities();
            _userQueries = new UserQueries
            {
                Context = _context
            };
        }
        public string TelephoneNumber { get; set; }
        public string Message { get; set; }
        public int Priority { get; set; }
        public string Username { get; set; }
      

        public string AddData()
        {
            if (TelephoneNumber == string.Empty)
            {
                return "noTelephoneNumber";
            }
            if (Message == string.Empty)
            {
                return "noMessage";
            }
            _priorityNumber = Convert.ToInt32(Priority);
            var userList = _userQueries.RetrieveItems(Username);
            var wantedUser = userList.First(c => c.Username == Username);
            var smsCollection = new SMSCollection
            {
                MessageContent = Message,
                PhoneNumber = TelephoneNumber,
                Priority = _priorityNumber,
                RecievedDateStamp = DateTime.Now,
                UserID = wantedUser.UserId,
                IsSent = false
            };
            _context.SMSCollection.Add(smsCollection);
            _context.SaveChanges();
            return "sentToDB";
        }

    }
}