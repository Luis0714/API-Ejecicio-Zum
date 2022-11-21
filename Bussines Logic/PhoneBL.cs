using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B_Interfacese;
using BC_DataAcessLayer;
using BC_Entities;

namespace Bussines_Logic
{
  
    public class PhoneBL
    {
        private readonly IMessageSender _EmailSender;
        private readonly IMessageSender _TextMessageSender;
        private readonly PhoneDAL _PhoneDal;

        public PhoneBL(PhoneDAL PhoneDal, IMessageSender EmailSender, IMessageSender TextMessageSender)
        {
            _PhoneDal = PhoneDal;
            _EmailSender = EmailSender;
            _TextMessageSender = TextMessageSender;
        }
       public IReadOnlyList<Phone> GetPhones()
        {
            return _PhoneDal.GetPhones();
        }

        public Phone GetPhoneByID(Guid id)
        {
            return _PhoneDal.GetPhoneById(id);
        }

        public IReadOnlyList<Phone> GetPhoneByYear(int year)
        {
            IEnumerable<Phone> phons = from phone in this._PhoneDal.GetPhones()
                                       where phone.ReleaseYear >= year
                                       select phone;

            return phons.ToList();
        }

        public IReadOnlyList<Phone> GetPhoneByBrandAndYear(string Brand, int year)
        {
            IEnumerable<Phone> phons = from phone in _PhoneDal.GetPhones()
                                       where phone.ReleaseYear == year && phone.Brand == Brand
                                       select phone;

            return phons.ToList();
        }

        public IReadOnlyList<Phone> GetPhoneOrderByBrand()
        {
            return _PhoneDal.GetPhones().OrderByDescending(phone => phone.Brand).ToList();
        }

        public IReadOnlyList<Phone> GetPhoneOrderByYear()
        {
            return _PhoneDal.GetPhones().OrderByDescending(phone => phone.ReleaseYear).ToList();
        }


        public string SendMessageEmail(Guid id)
        {
            Random r = new Random();
            Phone from = this.GetPhoneByID(id);
            Phone to = this.GetPhones()[r.Next(this.GetPhones().Count)];

            return _EmailSender.SendMessage("SALUDO", "ID: " + from.Id + " Marca: " + from.Brand,
                "ID: " + to.Id + " Marca: " + to.Brand,
                "HOLA TE ENVIO ESTE MESAJE");
        }

        public string SendMessageText(Guid id)
        {
            Random r = new Random();
            Phone from = this.GetPhoneByID(id);
            Phone to = this.GetPhones()[r.Next(this.GetPhones().Count)];

            return _TextMessageSender.SendMessage("SALUDO", "ID: " + from.Id + " Marca: " + from.Brand,
                "ID: " + to.Id + " Marca: " + to.Brand,
                "HOLA TE ENVIO ESTE MESAJE");
        }

    }
}
