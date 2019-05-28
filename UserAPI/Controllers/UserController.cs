using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UsersAPI.Models;
using Swashbuckle.Swagger.Annotations;
namespace UsersAPI.Controllers
{
    public class UserController : ApiController
    {
        // GET: api/User
        [SwaggerOperation("GetAll")]
        public IEnumerable<User> Get()
        {
            return new User[] {
                new User {Id=1,FirstName="Nagendra",LastName="Raja"},
                new User {Id=2,FirstName="Kalyani",LastName="Varada"},
                new User {Id=3,FirstName="Mohan",LastName="Mangala"}
            };
        }

        // GET: api/User/5
        [SwaggerOperation("GetById")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        [SwaggerOperation("Create")]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        [SwaggerOperation("Update")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        [SwaggerOperation("Delete")]
        public void Delete(int id)
        {
        }
    }
}
