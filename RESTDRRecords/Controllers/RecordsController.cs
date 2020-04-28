using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTDRRecords.Models;

namespace RESTDRRecords.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        private static int _idCounter = 0;
        private static readonly List<Record> _recordList = new List<Record>();
        

        // GET: api/Records
        [HttpGet]
        public IEnumerable<Record> Get()
        {
            return _recordList;
        }

        // GET: api/Records/5
        [HttpGet("{id}", Name = "Get")]
        public Record Get(int id)
        {
            return _recordList.Find(i => i.Id == id);
        }

        // POST: api/Records
        [HttpPost]
        public void Post([FromBody] Record value)
        {
            value.Id = _idCounter;
            _recordList.Add(value);
            _idCounter++;

        }

        // PUT: api/Records/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Record value)
        {
            Record r = Get(id);

            if (r != null)
            {
                r.Title = value.Title;
                r.Artist = value.Artist;
                r.ReleaseYear = value.ReleaseYear;
                r.Id = value.Id;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _recordList.Remove(_recordList.Find(i => i.Id == id));
        }
    }
}
