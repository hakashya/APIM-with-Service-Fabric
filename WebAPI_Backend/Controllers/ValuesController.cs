using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.ServiceModel.Channels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace WebAPI_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        /*public ActionResult<IEnumerable<JObject>> Get()
        {
            string jsonline = System.IO.File.ReadAllText(WebAPI_Backend.filePath);
            JObject obj = JObject.Parse(jsonline);
            //var response = Request.CreateResponse(HttpStatusCode.OK, obj, Configuration.Formatters.JsonFormatter);
            return new JObject[] { obj };
            //return new string[] { WebAPI_Backend.filePath, "value2" };
        }*/
        public IActionResult Get()
        {
            return NoContent();
        }

        // GET api/values/5

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
