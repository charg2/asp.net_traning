#nullable disable
using Microsoft.EntityFrameworkCore;

namespace MVCTraning.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MVCTraning.Models.Movie> Movie { get; set; }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseMySql(
                       @"Server=127.0.0.1; Database=moives; User=root; Pwd=zx0925^^",
                        MySqlServerVersion.Parse( "8.0.22-mysql" ) );
        }
    }
}
