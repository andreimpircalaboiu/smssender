using System.Web.Mvc;
using SmsSender.Client.Models;
using SmsSender.Client.Services;

namespace SmsSender.Client.Controllers
{
    public class MessageController : Controller
    {
        [HttpGet]
        public ActionResult Send(User user)
        {
            var message = new Message();
            ViewBag.Username = user.Username;
            message.Username = user.Username;
            return View(message);
        }
        [HttpPost]
        public ActionResult Send(Message inputMessage)
        {
            ViewBag.Username = inputMessage.Username;
            if (ModelState.IsValid == false)
            {
                return View(inputMessage);
            }
            var messageManager = new MessageSoapService();
            var result = messageManager.Authenticate(inputMessage.PhoneNumber, inputMessage.MessageContent,
                inputMessage.Priority, inputMessage.Username);
            if (result == "sentToDB")
            {
                var newMessage = new Message()
                {
                    Username = inputMessage.Username,
                    SuccessMessage = "Mesajul a fost trimis cu sucess"
                };
                ModelState.Clear();
                return View(newMessage);
            }
            else
            {
                return View(inputMessage);
            }
 
        }
    }
}