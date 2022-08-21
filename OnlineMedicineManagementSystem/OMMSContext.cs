using Microsoft.EntityFrameworkCore;

namespace OnlineMedicineManagementSystem
{
    public class OMMSContext:DbContext
    {
        public OMMSContext()
        {

        }
        public OMMSContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<User>UserMaster { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=OMMS;Integrated Security=true");
        }
        public DbSet<Medicines> MedicinesMaster { get; set; }

      

        
        
    }
}
