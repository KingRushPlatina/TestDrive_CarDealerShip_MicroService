
using CostumersApi.Data;
using CostumersApi.Interfaces;
using CostumersApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CostumersApi.Services
{
    public class CostumerService : ICostumer
    {
        private ApiDbdataContext dbContext;
        public CostumerService()
        {
            dbContext = new ApiDbdataContext();
        }

        public async Task Add(Reservation costumer)
        {
            var veicleInDb =await dbContext.Vehciles.FirstOrDefaultAsync(v=> v.Id == costumer.VeicleId);
            if(veicleInDb == null)
            {
                await dbContext.Vehciles.AddAsync(costumer.vehicle);
                await dbContext.SaveChangesAsync();
            }
            costumer.vehicle = null;
            await dbContext.Costumers.AddAsync(costumer);
            await dbContext.SaveChangesAsync();
        }
        
    }
}
