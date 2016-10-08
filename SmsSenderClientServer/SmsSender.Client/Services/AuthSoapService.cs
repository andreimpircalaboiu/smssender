using SmsSender.Client.Service_References.SMSWebService;

namespace SmsSender.Client.Services
{
    public class AuthSoapService
    {
        public string Authenticate(string username,string password)
        {
            var client = new SMSServiceSoapClient();
            return client.GetAuthentification(username, password);
        }
    }
}