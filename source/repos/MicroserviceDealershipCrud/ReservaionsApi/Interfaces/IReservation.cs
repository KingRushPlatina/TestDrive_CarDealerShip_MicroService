using  ReservationApi.Models;

namespace ReservationApi.Interfaces
{
    public interface IReservation
    {
        Task <List<Reservation>> GetReservations();
        Task UpdateMalStatus(int id);
    }
}
