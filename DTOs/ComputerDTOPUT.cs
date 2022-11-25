using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class ComputerDTOPUT
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

       
            public ComputerDTOPUT(string Id,string Brand, string Modelo, int RealeseYear, string Color, int DefaultCapacity, int MaxCapacity, string Processor, int TypeDisc, int DiscCapacity, int TypeComputer)
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
