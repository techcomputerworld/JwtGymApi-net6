using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions;
using JwtGymApi_net6.Data.Entities;
using Microsoft.Extensions.Configuration;

namespace JwtGymApi_net6.Data
{
    public class WebApiDbContext : DbContext
    {
        private readonly IConfiguration Configuration;
        public DbSet<User> Users { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<Exercises> Exercises { get; set; }
        public DbSet<Technicians> Technicians { get; set; }
        public WebApiDbContext()
        {

        }
        public WebApiDbContext(DbContextOptions<WebApiDbContext> options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
        }

        //public WebApiDbContext(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }



    }
}