using Microsoft.AspNetCore.Mvc;

namespace OnlineMedicineManagementSystem.Controllers
{
    public class DonateController : Controller
    {
        public IActionResult Donate()
        {
            List<Medicines> medicines = new List<Medicines>();
            using (OMMSContext db = new OMMSContext())
            {
                medicines = db.MedicinesMaster.Where(x => x.RollId == 5).ToList();
            }
            return View(medicines);
        }
    }
}