using System;
using System.Collections.Generic;
using System.Linq;

namespace SmsSender.Data.DbServices
{
    public class UserQueries : IDbQueries<Users>
    {

        public DBSMSEntities Context
        {
            get;
            set;
        }

        public IList<Users> RetrieveItems(string key)
        {
            try
            {
                var wantedUserArray = Context.Users.Where(c => c.Username.Equals(key)).ToList();
                return wantedUserArray;
            }
            catch (ArgumentNullException)
            {
                var wantedUserArray = new List<Users>();
                return wantedUserArray;
            }
        }
    }
}