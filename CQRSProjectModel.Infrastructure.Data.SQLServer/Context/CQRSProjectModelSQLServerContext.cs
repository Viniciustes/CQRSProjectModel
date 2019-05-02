using CQRSProjectModel.Infrastructure.Data.SQLServer.Mappings;
using Microsoft.EntityFrameworkCore;

namespace CQRSProjectModel.Infrastructure.Data.SQLServer.Context
{
    public class CQRSProjectModelSQLServerContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaMapping());

            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // get the configuration from the app settings
        //    var config = new ConfigurationBuilder()
        //        .SetBasePath(_env.ContentRootPath)
        //        .AddJsonFile("appsettings.json")
        //        .Build();

        //    // define the database to use
        //    optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        //}
    }
}
