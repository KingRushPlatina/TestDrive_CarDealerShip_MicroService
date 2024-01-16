
using Microsoft.EntityFrameworkCore;
using ReservationApi.Data;
using ReservationApi.Interfaces;
using ReservationApi.Models;

namespace ReservationApi.Services
{
    public class ReservationService : IReservation
    {
        private ApiDbdataContext dbContext;
        public ReservationService()
        {
            dbContext = new ApiDbdataContext();
        }

        public Task<List<Reservation>> GetReservations()
        {
            throw new Exception("n");
        }
            

        public async Task UpdateMalStatus(int id)
        {
             throw new Exception("n");
        }
    }
}
