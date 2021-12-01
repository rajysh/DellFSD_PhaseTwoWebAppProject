using Microsoft.EntityFrameworkCore;

namespace Day5_CoreCodeFirstApproachApp.Models
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=W102XZP8Y2;Database=DemoCodeFirstDB;Integrated Security=true;");
            //optionsBuilder.UseSqlServer("Server=W102XZP8Y2;Database=DemoDB;User Id=sa;Password=password123#;");
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
