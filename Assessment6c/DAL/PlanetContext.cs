using Assessment6c.Models;
using Microsoft.EntityFrameworkCore;


namespace Assessment6c.DAL
{
    public class PlanetContext : DbContext
    {
        public PlanetContext() { }


        public PlanetContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Planet> Planets { get; set; }


        private static IConfigurationRoot _configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            if (!optionsBuilder.IsConfigured)

            {

                var builder = new ConfigurationBuilder()

                    .SetBasePath(Directory.GetCurrentDirectory())

                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);


                _configuration = builder.Build();

                string cnstr = _configuration.GetConnectionString("PlanetDb");

                optionsBuilder.UseSqlServer(cnstr);

            }

        }

    }
}