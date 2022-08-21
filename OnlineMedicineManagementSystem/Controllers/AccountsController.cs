using Microsoft.AspNetCore.Mvc;
using OnlineMedicineManagementSystem.Models;

namespace OnlineMedicineManagementSystem.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Signin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signin(UserLogin user)
        {
            using (OMMSContext db=new OMMSContext())
            {
                var users = db.UserMaster.Where(x => x.UserId == user.UserId && x.Password == user.Password ).ToList();

                if(users.Count()>0)
                {
                    HttpContext.Session.SetString("name", users[0].FullName);
                    HttpContext.Session.SetInt32("role", users[0].RollId);
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    TempData["LoginStatus"] = "Fail";
                }
            }
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signup(User user)
        {
            user.RollId = 2;
            using (OMMSContext db=new OMMSContext())
            {
                db.UserMaster.Add(user);
                if(db.SaveChanges()>0)
                {
                    TempData["signupstatus"] = "ok";
                }
                
            }
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Signin","Accounts");
        }

    }
}
