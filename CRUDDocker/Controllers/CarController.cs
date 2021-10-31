using CRUDDocker.Model;
using CRUDDocker.RequestModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRUDDocker.Controllers
{
    [Route("api/cars")]
    [ApiController]
    public class CarController : ControllerBase
    {
        
        private static List<Car> cars = new List<Car>() {
                new Car { Id= 1, Name= "BMW", Color = "Red" },
                new Car { Id = 2, Name = "Audi", Color = "White" },
                new Car { Id = 3, Name = "Honda", Color = "Yellow" }
        };

        public CarController() {
        
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { cars});
        }

        // GET api/<CarController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Car result = null;
            string message = "Find id between 1 and 3";
            foreach (var car in cars)
            {
                if (car.Id == id)
                {
                    result = car;
                    message = "Success";
                }
            }

            return Ok(new { car = result, message }) ;
        }

        // POST api/<CarController>
        [HttpPost]
        public IActionResult Post([FromBody] RequestCreateCar request)
        {
            Car newCar = new Car
            {
                Name = request.Name,
                Color = request.Color
            };
            cars.Add(newCar);
            return Ok(newCar);
        }

        // PUT api/<CarController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] RequestUpdateCar updateCar)
        {
            Car car = cars.Find(car => car.Id == id);
            if (car != null) {
                car.Name = updateCar.Name;
                car.Color = updateCar.Color;
                return Ok(new { car, message = "Success" });
            }
            return BadRequest(new { car = "", message = "Not found car" });
        }

        // DELETE api/<CarController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            string message = "Delete base on id between 1 and 3";
            var result = cars.RemoveAll(car => car.Id == id);
            if (result > 0)
            {
                message = "Delete succesed.";
            }
            return Ok(new { message });
        }
    }
}
