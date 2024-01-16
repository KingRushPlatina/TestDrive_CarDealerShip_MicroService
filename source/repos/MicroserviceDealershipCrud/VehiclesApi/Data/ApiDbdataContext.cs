using Microsoft.EntityFrameworkCore;
using VehiclesApi.Models;

namespace VehiclesApi.Data
{
    public class ApiDbdataContext:DbContext
    {
       public DbSet<Vehicle> Vehciles { get; set; }  //returns the Dbset of veicles

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=VehicleApiDb;");
        }
    }
}
