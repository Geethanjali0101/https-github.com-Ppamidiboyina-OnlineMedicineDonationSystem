using Microsoft.AspNetCore.Mvc;
using OnlineMedicineManagementSystem;
using System.Collections.Generic;

namespace OnlineMedicineManagementSystem.Controllers
{
    public class MedicineDetailsController : Controller
    {
        public IActionResult MedicineDetails()
        {
            List<Medicines> medicines = new List<Medicines>();
            
            using (OMMSContext db = new OMMSContext())
            {
                medicines = db.MedicinesMaster.Where(x => x.RollId == 4).ToList();
                
            }
            return View(medicines);
        }
        


        

    }
}




