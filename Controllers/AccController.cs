using Day6task.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day6task.Controllers
{
    public class AccController : Controller
    {
        //Acc/login
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Login login)
        {
            if (login.Email== "ahmed.ragab01026@gmail.com"&& login.Password==123) {

                return RedirectToAction("index","Home");
            }

            return View();
        }






    }
}
