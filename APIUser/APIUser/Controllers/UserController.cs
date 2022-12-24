using APIUser.Database;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIUser.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        ContextDb db;
        public UserController()
        {
            db = new ContextDb();
        }
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return db.Users.ToList();
        }

     
        // POST api/<UserController>
        [HttpPost]
        public User Post(User user)
        {
            return user;
        }

        // PUT api/<UserController>/5
        [HttpPut]
        [Route("Update/Car")]
        public void Put(User us,int id)
        {
            var LD = id;
            var v = 123;
        }

        // DELETE api/<UserController>/5
        [HttpDelete]
        [Route("delete/car")]
        public void Delete(int id)
        {
            var LD = id;
            var v = 123;
        }
    }
}
