using System;
using System.Collections.Generic;
using System.Linq;

namespace SmsSender.Data.DbServices
{
    public class MessageQueries : IDbQueries<SMSCollection>
    {
        public DBSMSEntities Context
        {
            get;
            set;
        }
        public IList<SMSCollection> RetrieveItems(string key)
        {
            try
            {
                var wantedSmsArray = Context.SMSCollection.Where(m => m.IsSent == false).ToList();
                return wantedSmsArray;
            }
            catch (ArgumentNullException)
            {
                var wantedSmsArray = new List<SMSCollection>();
                return wantedSmsArray;
            }
        }
    }
}
