using Microsoft.EntityFrameworkCore;
using VehiclesApi.Data;
using VehiclesApi.Interfaces;
using VehiclesApi.Models;

namespace VehiclesApi.Services
{
    public class VehicleService : IVehicle
    {
        private ApiDbdataContext dbContext;
        public VehicleService()
        {
            dbContext = new ApiDbdataContext();
        }

        public async Task Add(Vehicle vehicle)
        {
            await dbContext.Vehciles.AddAsync(vehicle);
            await dbContext.SaveChangesAsync();
        }

        public  async Task Delete(int id)
        {
            var vehicle = await dbContext.Vehciles.FindAsync(id);
            _ = dbContext.Remove(vehicle);
            await dbContext.SaveChangesAsync();  //always call this method when we alter the table
        }

        public async Task<Vehicle> Get(int id)
        {
            var vehicle =await dbContext.Vehciles.FindAsync(id);
            return vehicle;
        }

        public async Task<List<Vehicle>> GetAll()
        {
            var vehicles = await dbContext.Vehciles.ToListAsync();
            return vehicles;
        }

        public async Task Update(int id, Vehicle vehicle)
        {
           var vehicleObj= await dbContext.Vehciles.FindAsync(id);
           vehicleObj.Name=vehicle.Name;
           vehicleObj.Width=vehicle.Width;
           vehicleObj.Height=vehicle.Height;
           vehicleObj.Price=vehicle.Price;
           vehicleObj.imageUrl = vehicle.imageUrl;
           vehicleObj.Displacement=vehicle.Displacement;
           vehicleObj.MaxSpeed=vehicle.MaxSpeed;
           await dbContext.SaveChangesAsync();
        }
    }
}
