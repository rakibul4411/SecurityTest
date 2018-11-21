using SecurityTest.Models;
using SecurityTest.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SecurityTest.Controllers
{
    public class AccountController : Controller
    {
        PersonContext db = new PersonContext();
        // GET: Acount
        public ActionResult LogIn()
        {           
            return View();
        }
        [HttpPost]
        public ActionResult LogIn([Bind(Include ="UserName,Password")] MemberShipVM model)
        {
            if (ModelState.IsValid)
            {
                bool isValid = db.users.Any(x => x.UserName == model.UserName && x.Password == model.Password);
                if (isValid)
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Index", "People");
                }
                ModelState.AddModelError("", "Invalid user name and password");
            }
                return View(model);
           
        }
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(MemberShipVM model)
        {
            if (ModelState.IsValid)
            {
                user user = new user();
                user.ID = model.ID;
                user.UserName = model.UserName;
                user.Password = model.Password;
                db.users.Add(user);
                db.SaveChanges();
            }
            return RedirectToAction("LogIn");
        }
        public ActionResult logOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LogIn");
        }
    }
}