using BC_Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BC_DataAcessLayer
{
    public class PhoneDAL
    {
        private static List<Phone> Phones = new List<Phone>()
        {
            new Phone( "Samsung",2022),
            new Phone( "Honor",2019),
            new Phone( "Motorola",2018),
            new Phone( "Realme",2017)
            ,new Phone( "Apple",2011),
            new Phone( "Xiaomi",2015),
            new Phone( "Realme",2018),
            new Phone( "Apple",2010),
            new Phone( "Huawei",2021),
            new Phone( "Honor",2007)
        };
     
        public List<Phone> GetPhones() {
            return Phones;
        }

        public Phone GetPhoneById(Guid id)
        {
            return Phones.FirstOrDefault(p => p.Id == id);
        }

    }
}
