using Microsoft.EntityFrameworkCore;


namespace EFCoreTraning.Models
{
    public class EFCoreDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseMySql(
                       @"Server=127.0.0.1; Database=ef_test; User=root; Pwd=1234",
                        MySqlServerVersion.Parse("8.0.22-mysql") );
        }
    }
}
