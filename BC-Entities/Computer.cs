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
        public Guid _Id { get; set; }
        public string _Brand { get; set; }
        public string _Modelo { get; set; }
        public int _RealeseYear { get; set; }
        public string _Color { get; set; }

        public int _DefaultCapacity { get; set; }
        public int _MaxCapacity { get; set; }

        public string _Processor { get; set; }

        public TypeDisc _TypeDisc { get; set; }

        public int _DiscCapacity { get; set; }

        public TypeComputer _TypeComputer { get; set; }

        public Computer(string Brand, string Modelo, int RealeseYear, string Color, int DefaultCapacity, int MaxCapacity, string Processor, TypeDisc TypeDisc, int DiscCapacity, TypeComputer TypeComputer)
        {
            _Id = Guid.NewGuid();
            _Brand = Brand;
            _Modelo = Modelo;
            _RealeseYear = RealeseYear;
            _Color = Color;
            _DefaultCapacity = DefaultCapacity;
            _MaxCapacity = MaxCapacity;
            _Processor = Processor;
            _TypeDisc = TypeDisc;
            _DiscCapacity = DiscCapacity;
            _TypeComputer = TypeComputer;
        }



        }

    }

    