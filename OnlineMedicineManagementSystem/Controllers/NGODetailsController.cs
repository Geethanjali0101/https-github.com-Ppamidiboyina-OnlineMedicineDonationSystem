using Microsoft.AspNetCore.Mvc;

namespace OnlineMedicineManagementSystem.Controllers
{
    public class NGODetailsController : Controller
    {
        public IActionResult NGODetails()
        {
            List<User> users = new List<User>();
            using (OMMSContext db = new OMMSContext())
            {
                users = db.UserMaster.Where(x => x.RollId == 3).ToList();
            }
            return View(users);
        }
    }
}
