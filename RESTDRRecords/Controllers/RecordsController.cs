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
        private static readonly List<Record> _recordList = new List<Record>()
        {
            new Record("Record 1", "Artist 1", 2020),
            new Record("Record 1", "Artist 2", 2010),
            new Record("Record 2", "Artist 2", 2000),
            new Record("Record 3", "Artist 3", 2010),
            new Record("Record 4", "Artist 4", 2005)
        };

        // GET: api/Records
        [HttpGet]
        public IEnumerable<Record> Get()
        {
            return _recordList;
        }

        // GET: api/Records/5
        [HttpGet("{title}", Name = "Get")]
        public List<Record> Get(string title)
        {
            return _recordList.FindAll(i => i.Title == title);
        }

        // POST: api/Records
        [HttpPost]
        public void Post([FromBody] Record value)
        {
            _recordList.Add(value);
        }

        // PUT: api/Records/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
