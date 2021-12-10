using Microsoft.EntityFrameworkCore;

namespace Day5_CoreCodeFirstApproachApp.Models
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        { 
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<AuthorBiography> AuthorBiographies { get; set; }
        public DbSet<Novel> Novels { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<NovelCategory> NovelCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NovelCategory>().HasKey(
                c => new { c.NovelId, c.CategoryId });

            modelBuilder.Entity<NovelCategory>()
                .HasOne(c => c.Novel)
                .WithMany(c => c.NovelCategories)
                .HasForeignKey(c => c.NovelId);

            modelBuilder.Entity<NovelCategory>()
                .HasOne(c => c.Category)
                .WithMany(c => c.NovelCategories)
                .HasForeignKey(c => c.CategoryId);

            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=W102XZP8Y2;Database=DemoCodeFirstDB;Integrated Security=true;");
        //    //optionsBuilder.UseSqlServer("Server=W102XZP8Y2;Database=DemoDB;User Id=sa;Password=password123#;");
        //    //base.OnConfiguring(optionsBuilder);
        //}
    }
}
