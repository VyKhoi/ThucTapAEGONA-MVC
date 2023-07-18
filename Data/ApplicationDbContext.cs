using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ThucTapMVC.Models;

namespace ThucTapMVC.Data
{
    public class ApplicationDbContext :DbContext
    {
        protected readonly IConfiguration Configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mysql with connection string from app settings
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<Contacts> Contacts { set; get; }
    }
}
