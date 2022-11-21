using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BC_Entities;
using WebApiEjercicio.Data;
using Bussines_Logic;
using B_Services;
using B_Interfacese;

namespace WebApiEjercicio.Controllers
{
    public class PhonesController : ApiController 
    {
        private readonly PhoneBL _PhoneBL;
        private readonly IMessageSender _EmailSender;
        private readonly IMessageSender _TextMessageSender;

    

        public PhonesController(PhoneBL PhoneBL)
        {
            _PhoneBL = PhoneBL;
         
        }


       
        // GET: api/Phones/5
        [ResponseType(typeof(Phone))]
        public IHttpActionResult GetPhone(Guid id)
        {
            Phone phone = _PhoneBL.GetPhoneByID(id);
            if (phone == null)
            {
                return NotFound();
            }
            return Ok(phone);
        }
      

        [ResponseType(typeof(Phone))]
        public IReadOnlyList<Phone> GetPhoneByYear(int year)
        {
            return _PhoneBL.GetPhoneByYear(year);
        }

        [ResponseType(typeof(Phone))]
        public IReadOnlyList<Phone> GetPhoneByBrandAndYear(string Brand, int year)
        {
            return _PhoneBL.GetPhoneByBrandAndYear(Brand, year);
        }


        [ResponseType(typeof(Phone))]
        public IReadOnlyList<Phone> GetPhoneOrderByYear()
        {
            return _PhoneBL.GetPhoneOrderByYear();
        }

        [HttpGet]
        [Route("sendEmail")]
        public String SendMessageEmail(Guid id)
        {
            return _PhoneBL.SendMessageEmail(id); 
        }
    }
}



    