using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace WebAPI.Controllers
{
    [Route("api/record")]
    public class ValuesController : Controller
    {
        static List<string> record = new List<string>();
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return record;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return record[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]JObject value)
        {
            record.Add(value.GetValue("value").ToString());
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]JObject value)
        {
            record[id] = value.GetValue("value").ToString();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
