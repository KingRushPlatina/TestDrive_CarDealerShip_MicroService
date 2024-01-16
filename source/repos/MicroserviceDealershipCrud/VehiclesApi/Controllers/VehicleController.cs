using Microsoft.AspNetCore.Mvc;
using VehiclesApi.Interfaces;
using VehiclesApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VehiclesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private IVehicle _vehileService;
        public VehicleController(IVehicle vehicleService)
        {
            _vehileService = vehicleService;
        }
        [HttpGet]
        public async Task<IEnumerable<Vehicle>> Get()
        {
            return await _vehileService.GetAll();
        }

      
        [HttpGet("{id}")]
        public async Task<Vehicle> Get(int id)
        {
            return await _vehileService.Get(id);
        }

       
        [HttpPost]
        public async Task Post([FromBody] Vehicle vehicle)
        {
            await _vehileService.Add(vehicle);
        }

        
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Vehicle value)
        {
           
            await _vehileService.Update(id,value);
        }

       
        [HttpDelete("{id}")]
        public async Task  Delete(int id)
        {
            await _vehileService.Delete(id);
        }
    }
}
