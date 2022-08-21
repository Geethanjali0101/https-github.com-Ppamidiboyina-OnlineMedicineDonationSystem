using Microsoft.AspNetCore.Mvc;

namespace OnlineMedicineManagementSystem.Controllers
{
    public class MedicinesController : Controller
    {
        public IActionResult AddMedicines()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMedicines(Medicines medicines)
        {
            medicines.RollId = 4;

            using (OMMSContext db = new OMMSContext())
            {
                db.MedicinesMaster.Add(medicines);
                if (db.SaveChanges() > 0)
                {
                    TempData["addmedicinesstatus"] = "ok";
                }

            }
            return View();
        }
    }
}
