using BC_Entities;
using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_DataAcessLayer
{
    public class ComputerDAL
    {
        private static List<Computer> _Computers = new List<Computer>()
        {
            new Computer("HP","SHP-233",2022,"Gris",4,8,"AMD Ryzen 3",TypeDisc.SSD,500,TypeComputer.LAPTOP)
        };


        public List<Computer> GetPhones()
        {
            return _Computers;
        }

        public Computer SaveComputer(Computer computer)
        {
            _Computers.Add(computer);
            return _Computers.FirstOrDefault(c => c._Id == computer._Id);
        }

        public Computer GetComputerByID(Guid id)
        {
            return _Computers.FirstOrDefault(C => C._Id == id);
        }
        
        public bool RemoveComputer(Computer computer)
        {
            return _Computers.Remove(computer);
        }
    }
}

