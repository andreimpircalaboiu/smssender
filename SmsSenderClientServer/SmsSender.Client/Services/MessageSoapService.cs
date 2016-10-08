using System;
using SmsSender.Client.Models;
using SmsSender.Client.Service_References.SMSWebService;

namespace SmsSender.Client.Services
{
    public class MessageSoapService
    {
        public string Authenticate(string telephoneNumber, string message, Enums.Priority priorityEnum, string username)
        {
            var client = new SMSServiceSoapClient();
            var priority = Convert.ToInt32(priorityEnum.ToString("d"));
            return client.PostMessageData(telephoneNumber,message,priority,username);
        }
    }
}