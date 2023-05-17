using Guven_Barkod_BackEnd.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Guven_Barkod
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {

            //var configurationBuilder = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            //IConfigurationRoot configuration = configurationBuilder.Build();
            //string connectionString = configuration.GetConnectionString("Storage");

            DbContextOptionsBuilder<ProductRepo> optionsBuilder = new DbContextOptionsBuilder<ProductRepo>()
                .UseSqlServer(@"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BarkodV3;Integrated Security=True;Encrypt=False;");

            using (ProductRepo sc = new ProductRepo())
            {

                sc.Database.Migrate();

                sc.SaveChanges();
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Ms_Ekleme());
        }
    }
}