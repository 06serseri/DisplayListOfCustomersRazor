using DisplayListOfCustomers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DisplayListOfCustomers.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            List<UserModel> users = new List<UserModel>();
            users.Add(new UserModel("Polat Alemdar", "polat@gmail.com", "(123) 456-7890)"));
            users.Add(new UserModel("Ivan Drago", "ivan@gmail.com", "(123) 456-7890)"));
            users.Add(new UserModel("Memati Bas", "memati@gmail.com", "(123) 456-7890)"));
            users.Add(new UserModel("Gunnary Sergaent Hartman", "hartman@gmail.com", "(123) 456-7890)"));
             

            return View("Test", users);
        }
    }
}