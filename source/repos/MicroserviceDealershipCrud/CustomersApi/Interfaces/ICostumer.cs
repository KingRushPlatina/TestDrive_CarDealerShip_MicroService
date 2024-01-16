using CostumersApi.Models;

namespace CostumersApi.Interfaces
{
    public interface ICostumer
    {
        Task Add (Reservation costumer);
    }
}
