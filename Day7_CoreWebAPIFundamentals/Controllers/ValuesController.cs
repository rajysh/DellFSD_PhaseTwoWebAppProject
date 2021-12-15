using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Day7_CoreWebAPIFundamentals.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        static List<string> values = new List<string>()
        {
            "ValueOne", "ValueTwo", "ValueThree"
        };

        [HttpGet]
        [Route("vals")]
        public List<string> Get()
        {
            return values;
        }

        [HttpGet]
        //[Route("{index}")]
        //public string Get([FromRoute]int index)
        [Route("vals/{index}")]
        public string ListOfValues([FromRoute] int index)
        {
            return values[index];
        }

        [HttpPost]
        [Route("vals")]
        public List<string> AddValue([FromBody]string value)
        {
            values.Add(value);
            return values;
        }

        [HttpPut]
        [Route("vals/{index}")]
        public List<string> UpdateValue(int index, [FromBody]string value)
        {
            values[index] = value;
            return values;
        }

        [HttpDelete]
        [Route("vals/{index}")]
        public List<string> DeleteValue(int index)
        {
            values.RemoveAt(index);
            return values;
        }
    }
}
