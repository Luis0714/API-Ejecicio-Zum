using B_Interfacese;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_Entities
{
    public class Phone
    {
   
        public Guid Id { get; set; }
        public  string Brand { get; set; }
        public int ReleaseYear { get; set; }
      
        public Phone(string brand, int releaseYear)
        {
            this.Id =  Guid.NewGuid();
            this.Brand = brand;
            this.ReleaseYear = releaseYear;
           
        }


    }
}
