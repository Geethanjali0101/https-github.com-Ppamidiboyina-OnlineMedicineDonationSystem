using System.ComponentModel.DataAnnotations;

namespace OnlineMedicineManagementSystem
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; } 
        public int Age { get; set; }
        public string MobileNo { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public int RollId { get; set; }
        [Required]
        public string EmailId { get; set; }
        [Required]
        public string Address { get; set; }
       

   





    }
}
