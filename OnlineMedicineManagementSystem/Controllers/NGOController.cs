using Microsoft.AspNetCore.Mvc;
using OnlineMedicineManagementSystem.Models;

namespace OnlineMedicineManagementSystem.Controllers
{
    public class NGOController : Controller
    {
        public IActionResult AddNGO()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNGO(User user)
        {
            user.RollId = 3;
           
            using (OMMSContext db = new OMMSContext())
            {
                db.UserMaster.Add(user);
                if (db.SaveChanges() > 0)
                {
                    TempData["addngostatus"] = "ok";
                }

            }
            return View();
        }
    }
}
