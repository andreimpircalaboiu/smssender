using System;

namespace SmsSender.Data.DbServices
{
    public class DbSentStateSetter
    {
        public DBSMSEntities Context { get; set; }
        public bool SetIsSentToTrue(SMSCollection smsToBeEdited)
        {
            try
            {
                smsToBeEdited.IsSent = true;
                smsToBeEdited.SentDateStamp = DateTime.Now;
                Context.SMSCollection.Attach(smsToBeEdited);
                var entry = Context.Entry(smsToBeEdited);
                entry.State = System.Data.Entity.EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
      
        }
    }
}
