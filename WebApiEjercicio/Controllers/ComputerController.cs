using BC_Entities;
using Bussines_Logic;
using DTOs;
using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApiEjercicio.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins: "http://127.0.0.1:5501", headers: "*", methods: "*", SupportsCredentials = true)]
    //[ApiKeyFilters]
    public class ComputerController : ApiController
    {
        private readonly ComputerBL _ComputerBL;
        /*
         public ComputerController(ComputerBL computerBL)
         {
             _ComputerBL = computerBL;
         }
        */
        public ComputerController()
        {
            _ComputerBL = new ComputerBL();
        }
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
        [Route("Computers/update")]
        public IHttpActionResult Put([FromBody]ComputerDTOPUT computer)
        {
           return Ok( _ComputerBL.UpdateComputer(computer));
        }
      
        [HttpDelete]
        [Route("Computers/delete")]
        public IHttpActionResult Delete(string id)
        {
            return Ok(_ComputerBL.RemoveComputer(id));
        }
    }
}
