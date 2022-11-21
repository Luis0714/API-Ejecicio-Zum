using BC_Entities;
using Bussines_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiEjercicio.Controllers
{
    public class ComputerController : ApiController
    {
        ComputerBL _ComputerBL = new ComputerBL();
        // GET: api/Computer

        [HttpGet]
        [Route("Computers")]
        public IEnumerable<Computer> Get()
        {
            return _ComputerBL.GetPhones();
        }

        // GET: api/Computer/5
        [HttpGet]
        [Route("Computers/{id}")]
        public Computer Get(Guid id)
        {
            return _ComputerBL.GetComputerByID(id);
        }

        // POST: api/Computerc
        [HttpPost]
        [Route("Computers/create")]
        public Computer Post([FromBody]Computer computer)
        {
            return _ComputerBL.SaveComputer(computer);
        }

        // PUT: api/Computer/5
        [HttpPut]
        [Route("Computers/edit")]
        public bool Put(Guid id, [FromBody]Computer computer)
        {
           return _ComputerBL.UpdateComputer(id, computer);
        }

        // DELETE: api/Computer/5
        [HttpDelete]
        [Route("Computers/delete")]
        public bool Delete(Guid id)
        {
            return _ComputerBL.RemoveComputer(id);
        }
    }
}
