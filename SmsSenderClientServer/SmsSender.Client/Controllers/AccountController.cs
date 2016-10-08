using System.Web.Mvc;
using SmsSender.Client.Models;
using SmsSender.Client.Services;

namespace SmsSender.Client.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Login", "Account");
        }
        [HttpPost]
        public ActionResult Login(User inputUser)
        {
            ViewBag.Username = inputUser.Username;
            if (ModelState.IsValid == false)
            {
                return View(inputUser);
            }
            var authManager = new AuthSoapService();
            var result = authManager.Authenticate(inputUser.Username, inputUser.Password);
            if (result == inputUser.Username)
            {
                return RedirectToActionPermanent("Send","Message",inputUser);
            }
            else
            {
                switch (result)
                {
                    case "wrongUsername":
                        ModelState.AddModelError("Username", "Userul introdus nu exista.");
                        break;
                    case "wrongPassword":
                        ModelState.AddModelError("Password", "Parola introdusa este incorecta");
                        break;
                }
                return View(inputUser);
            }
        }
    }

}