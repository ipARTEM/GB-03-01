using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMicroservice.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TemperatureController : ControllerBase
    {
        private readonly List<Temperature> _temperatures;

        public TemperatureController(List<Temperature> temperature)
        {
            _temperatures = temperature;

        }


        [HttpGet]
        public IActionResult Read() =>
            Ok(_temperatures.OrderBy(item => item.Date));

        [HttpPost]
        public IActionResult Create([FromBody] Temperature temperature)
        {
            if (_temperatures.TrueForAll(item=>item.Date!=temperature.Date))
            _temperatures.Add(temperature);

            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] Temperature temperature)
        {
            _temperatures.FirstOrDefault(item => item.Date == temperature.Date)?.CopyData(temperature);

            return Ok();
        }


        [HttpDelete]
        public IActionResult Delete([FromBody] Temperature temperature)
        {
            if(temperature!=null)
           _temperatures.Remove( temperature);
            return Ok();
        }


    }
}
