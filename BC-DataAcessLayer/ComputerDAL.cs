using BC_Entities;
using Enums;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BC_DataAcessLayer
{
    public class ComputerDAL
    {
        private static List<Computer> _Computers = new List<Computer>()
        {
            new Computer("HP","JKNG-453",2022,"ROJO",4,8,"AMD Ryzen 5",TypeDisc.SSD,600,TypeComputer.DESK),
            new Computer("ACER","RTYY-456",2022,"GRIS",4,8,"AMD Ryzen 3",TypeDisc.HDD,400,TypeComputer.LAPTOP),
            new Computer("APPLE","RTYY-233",2022,"VERDE",4,8,"INTEL I7",TypeDisc.SSD,300,TypeComputer.LAPTOP)
        };

        private readonly string _connectionString;

        public ComputerDAL()
        {
            _connectionString = "Data Source=localhost;Database=ComputersDB;Integrated Security=True";
        
        }

        private async void unre()
        {
            var connection = new System.Data.SqlClient.SqlConnection(_connectionString);

            var sql = @"INSERT INTO Products ( _Id,
            _Brand,
            _Modelo,
            _RealeseYear,
            _Color,
            _DefaultCapacity,
            _MaxCapacity,
            _Processor,
            _TypeDisc,
            _DiscCapacity,
            _TypeComputer ) 
                            VALUES (@_Id,
            @_Brand,
           @_Modelo,
            @_RealeseYear,
            @_Color,
            @_DefaultCapacity,
            @_MaxCapacity,
            @_Processor,
            @_TypeDisc,
            @_DiscCapacity,
            @_TypeComputer )";

            //var affectedRows = await connection(sql, new Computer("HP", "SHP-233", 2022, "Gris", 4, 8, "AMD Ryzen 3", TypeDisc.SSD, 500, TypeComputer.LAPTOP));//new{Id=product.Id, Title=product.Title...}
            //return affectedRows;
        }
       

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

