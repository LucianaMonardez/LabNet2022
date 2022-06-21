using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lab.Northwind.Web.Api.Controllers
{
    public class ShippersController : ApiController
    {
        // GET: api/Shippers
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Shippers/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Shippers
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Shippers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Shippers/5
        public void Delete(int id)
        {
        }
    }
}
