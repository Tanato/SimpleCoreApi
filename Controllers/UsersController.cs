using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace SimpleCoreApi.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db.Users);
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            return db.Users.SingleOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public void Post([FromBody]User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var user = db.Users.SingleOrDefault(x => x.Id == id);
            if (true)
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }
    }
}
