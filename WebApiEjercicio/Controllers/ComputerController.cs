using BC_Entities;
using Bussines_Logic;
using DTOs;
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
        public List<Computer> Get()
        {
            return _ComputerBL.GetComputers();
        }

        // POST: api/Computerc
        [HttpPost]
        [Route("Computers/create")]
        public IHttpActionResult Post([FromBody]ComputerDTO computerDTO)
        {
            return Ok(_ComputerBL.SaveComputer(computerDTO));
        }

        [HttpPut]
        [Route("Computers/edit")]
        public IHttpActionResult Put(string id, [FromBody]ComputerDTO computer)
        {
           return Ok( _ComputerBL.UpdateComputer(id, computer));
        }

        // DELETE: api/Computer/5
        [HttpDelete]
        [Route("Computers/delete")]
        public IHttpActionResult Delete(string id)
        {
            return Ok(_ComputerBL.RemoveComputer(id));
        }
    }
}
