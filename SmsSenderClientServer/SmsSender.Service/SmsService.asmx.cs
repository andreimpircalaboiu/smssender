using System.Web.Services;

namespace SmsSender.Service
{
    /// <summary>
    /// Summary description for SMSService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/Service")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SmsService : System.Web.Services.WebService
    {
        [WebMethod]
        public string PostMessageData(string telephoneNumber , string message, int priority, string username)
        {
            var manager = new CrudManager()
            {
                Message = message,
                TelephoneNumber = telephoneNumber,
                Priority = priority,
                Username = username

            };
            return manager.AddData();
        }
        [WebMethod]
        public string GetAuthentification(string username, string password)
        {
            var inspector = new AuthenticationVerifier(username, password);
            return inspector.ValidateUser();
        }
    }
}
