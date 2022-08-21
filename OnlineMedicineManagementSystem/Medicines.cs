using System.ComponentModel.DataAnnotations;

namespace OnlineMedicineManagementSystem
{
    public class Medicines
    {
        public int Id { get; set; }
        [Required]
        public string MedicineName { get; set; }

        [Required]

        public int Price { get; set; }

        [Required]

        public int Quantity { get; set; }
       

        public int RollId { get; set; }
    }
}
