using Microsoft.AspNetCore.Mvc;

namespace OnlineMedicineManagementSystem.Controllers
{
    public class UserController : Controller
    {
        public IActionResult UserDetails()
        {
            List<User> users = new List<User>();
            using (OMMSContext db = new OMMSContext())
            {
                users = db.UserMaster.Where(x => x.RollId == 2).ToList();
            }
            return View(users);
        }
    }
}
