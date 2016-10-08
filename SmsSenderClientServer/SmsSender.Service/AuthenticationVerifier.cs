using System;
using System.Collections.Generic;
using System.Linq;
using SmsSender.Data;
using SmsSender.Data.DbServices;

namespace SmsSender.Service
{
    public class AuthenticationVerifier
    {
        private readonly string _username;
        private readonly string _password;

        public AuthenticationVerifier(string username, string password)
        {
            this._username = username;
            this._password = password;
        }

        public string ValidateUser()
        {
            string returnedMessage;
            IList<Users> wantedUserList;
            Users wantedUser;
            var userQuery = new UserQueries()
            {
                Context = new DBSMSEntities()
            };
            try
            {
                wantedUserList = userQuery.RetrieveItems(_username);
                wantedUser = wantedUserList.First(c => c.Username == _username);
            }
            catch (InvalidOperationException)
            {
                returnedMessage = "wrongUsername";
                return returnedMessage;
            }
            var isWantedPassword = wantedUserList.Any(c => c.Password == _password);
            if (isWantedPassword)
            {
                returnedMessage = wantedUser.Username;
                return returnedMessage;
            }
            returnedMessage = "wrongPassword";
            return returnedMessage;

        }

    }

}