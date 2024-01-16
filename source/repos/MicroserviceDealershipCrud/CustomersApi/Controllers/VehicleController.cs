using CostumersApi.Interfaces;
using CostumersApi.Services;
using Microsoft.AspNetCore.Mvc;
using CostumersApi.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CostumersApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CostumerController : ControllerBase
    {
        private ICostumer _costumerService;
        public CostumerController(ICostumer costumerService)
        {
           _costumerService = costumerService;
        }
       
        [HttpPost]
        public async Task Post([FromBody] Reservation vehicle)
        {
            await _costumerService.Add(vehicle);
        }

    }
}
