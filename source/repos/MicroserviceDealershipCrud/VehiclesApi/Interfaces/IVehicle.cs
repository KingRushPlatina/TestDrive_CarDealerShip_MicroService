using VehiclesApi.Models;

namespace VehiclesApi.Interfaces
{
    public interface IVehicle
    {
        Task<List<Vehicle>> GetAll();
        Task<Vehicle> Get(int id );
        Task Add (Vehicle vehicle);
        Task Update (int id,Vehicle vehicle);
        Task Delete (int id);
    }
}
