using BC_DataAcessLayer;
using BC_Entities;
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

        public ComputerBL()
        {
            _ComputerDAL = new ComputerDAL();
        }

        public List<Computer> GetPhones()
        {
            return _ComputerDAL.GetPhones();
        }

        public Computer SaveComputer(Computer computer)
        {
            return _ComputerDAL.SaveComputer(computer);
        }

        public Computer GetComputerByID(Guid id)
        {
            return _ComputerDAL.GetComputerByID(id);
        }

        public bool UpdateComputer(Guid id ,Computer computer)
        {
            var computerToUpdate = _ComputerDAL.GetComputerByID(id);
            _ComputerDAL.RemoveComputer(computerToUpdate);
            computerToUpdate = computer;
            return  _ComputerDAL.SaveComputer(computerToUpdate) != null;
        }

        public bool RemoveComputer(Guid id)
        {
            var computerToRemove = _ComputerDAL.GetComputerByID(id);
            return _ComputerDAL.RemoveComputer(computerToRemove);
        }
    }
}
