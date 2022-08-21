using Microsoft.AspNetCore.Mvc;

namespace OnlineMedicineManagementSystem.Controllers
{
    public class BuyMedicinesController : Controller
    {
        public IActionResult BuyMedicines()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BuyMedicines(Medicines medicines)
        {
            medicines.RollId = 5;

            using (OMMSContext db = new OMMSContext())
            {
                db.MedicinesMaster.Add(medicines);
                if (db.SaveChanges() > 0)
                {
                    TempData["buymedicinesstatus"] = "ok";
                }

            }
            return View();
        }
    }
}
