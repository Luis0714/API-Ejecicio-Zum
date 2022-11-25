using BC_DataAcessLayer;
using BC_Entities;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_Logic
{
    public class ComputerBL
    {
        private readonly ComputerDAL _ComputerDAL;
        /*
        public ComputerBL(ComputerDAL computerDAL)
        {
            _ComputerDAL = computerDAL;
        }
        */
        public ComputerBL()
        {
            _ComputerDAL = new ComputerDAL();
        }
        public List<Computer> GetComputers()
        {
            return _ComputerDAL.GetComputers();
        }

        public Computer SaveComputer(ComputerDTO DTO)
        {
            Computer computer = new Computer(DTO.Id,DTO.Brand, DTO.Modelo, DTO.RealeseYear, DTO.Color, DTO.DefaultCapacity, DTO.MaxCapacity, DTO.Processor,
                DTO.TypeDisc, DTO.DiscCapacity, DTO.TypeComputer);
            return _ComputerDAL.SaveComputer(computer);
        }
       

        public bool UpdateComputer(ComputerDTOPUT DTO)
        {
            Computer compute = new Computer(DTO.Id,DTO.Brand, DTO.Modelo, DTO.RealeseYear, DTO.Color, DTO.DefaultCapacity, DTO.MaxCapacity, DTO.Processor,
                DTO.TypeDisc, DTO.DiscCapacity, DTO.TypeComputer);
            return _ComputerDAL.UpdateComputer(compute);
        }

        public bool RemoveComputer(string id)
        {   
            return _ComputerDAL.RemoveComputer(id);
        }
    }
}
