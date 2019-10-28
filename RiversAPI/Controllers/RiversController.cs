using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RiversAPI.Models;

namespace RiversAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RiversController : ControllerBase
    {
        private RiversAPIContext _db;

        public RiversController(RiversAPIContext db)
        {
            _db = db;
        }

        // GET api/rivers
        [HttpGet]
        public ActionResult<IEnumerable<River>> Get(string name , string state, string mouth, string source, string tributary )
        {
            var query = _db.Rivers.AsQueryable();

            if (name != null)
            {
                query = query.Where(entry => entry.Name.Contains(name));
            }

            if (state != null)
            {
                query = query.Where(entry => entry.Counties.Contains(state));
            }

            if (mouth != null)
            {
                query = query.Where(entry => entry.Mouth.Contains(mouth));
            }

            if (source != null)
            {
                query = query.Where(entry => entry.Source.Contains(source));
            }

            if (tributary != null)
            {
                query = query.Where(entry => entry.Tributaries.Contains(tributary));
            }



            return query.ToList();
        }

        // POST api/rivers
        [HttpPost]
        public void Post([FromBody] River river)
        {
            _db.Rivers.Add(river);
            _db.SaveChanges();
        }

        // GET api/rivers/5
        [HttpGet("{id}")]
        public ActionResult<River> Get(int id)
        {
            return _db.Rivers.FirstOrDefault(entry => entry.RiverId == id);
        }

        // PUT api/rivers/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] River river)
        {
            river.RiverId = id;
            _db.Entry(river).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/rivers/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var riverToDelete = _db.Rivers.FirstOrDefault(entry => entry.RiverId == id);
            _db.Rivers.Remove(riverToDelete);
            _db.SaveChanges();
        }
    }
}