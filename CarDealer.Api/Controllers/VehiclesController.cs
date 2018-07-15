using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cardealer.api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarDealer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly DataContext context;
        public VehiclesController(DataContext context)
        {
            this.context = context;
        }

        // GET api/Vehicles
        [HttpGet]
        public async Task<ActionResult> GetVehicles()
        {
            var vehicles = await this.context.Vehicles.ToListAsync();
            return Ok(vehicles);
        }

        // GET api/Vehicles/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetVehicle(int id)
        {
            var vehicle = await this.context.Vehicles.FirstOrDefaultAsync(v => v.Id == id);
            return Ok(vehicle);
        }

        // POST api/Vehicles
        [HttpPost]
        public void Post([FromBody] string Vehicle)
        {
        }

        // PUT api/Vehicles/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string Vehicle)
        {
        }

        // DELETE api/Vehicles/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
