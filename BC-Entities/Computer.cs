using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_Entities
{
    public class Computer
    {
     
        public string Id { get; set; }
        public string Brand { get; set; }
        public string Modelo { get; set; }
        public int RealeseYear { get; set; }
        public string Color { get; set; }
        public int DefaultCapacity { get; set; }
        public int MaxCapacity { get; set; }
        public string Processor { get; set; }
        public int TypeDisc { get; set; }
        public int DiscCapacity { get; set; }
        public int TypeComputer { get; set; }

       
        public Computer(System.String Id, System.String Brand, System.String Modelo, System.Int32 RealeseYear, System.String Color, System.Int32 DefaultCapacity, System.Int32 MaxCapacity, 
            System.String Processor, System.Int32 TypeDisc, System.Int32 DiscCapacity, System.Int32 TypeComputer)
        {
            this.Id = Id;
            this.Brand = Brand;
            this.Modelo = Modelo;
            this.RealeseYear = RealeseYear;
            this.Color = Color;
            this.DefaultCapacity = DefaultCapacity;
            this.MaxCapacity = MaxCapacity;
            this.Processor = Processor;
            this.TypeDisc = TypeDisc;
            this.DiscCapacity = DiscCapacity;
            this.TypeComputer = TypeComputer;
        }


    }

}

    