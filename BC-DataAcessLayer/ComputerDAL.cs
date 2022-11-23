using BC_Entities;
using Dapper;
using DTOs;
using Enums;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BC_DataAcessLayer
{
    public class ComputerDAL
    {
        /*
        private static List<Computer> _Computers = new List<Computer>()
        {
            new Computer("HP","JKNG-453",2022,"ROJO",4,8,"AMD Ryzen 5",TypeDisc.SSD,600,TypeComputer.DESK),
            new Computer("ACER","RTYY-456",2022,"GRIS",4,8,"AMD Ryzen 3",TypeDisc.HDD,400,TypeComputer.LAPTOP),
            new Computer("APPLE","RTYY-233",2022,"VERDE",4,8,"INTEL I7",TypeDisc.SSD,300,TypeComputer.LAPTOP)
        };
        */
        //private Computer computerP = new Computer("APPLE", "RTYY-233", 2022, "VERDE", 4, 8, "INTEL I7", (int)TypeDisc.SSD, 300, (int)TypeComputer.LAPTOP);


        private readonly string _connectionString;

        public ComputerDAL()
        {
            _connectionString = "Data Source=localhost;Database=ComputersDB;Integrated Security=True";
        
        }

        private Computer Insert(Computer computer)
        {
            var sql = @"INSERT INTO Computers (
            Id,
            Brand,
            Modelo,
            RealeseYear,
            Color,
            DefaultCapacity,
            MaxCapacity,
            Processor,
            TypeDisc,
            DiscCapacity,
            TypeComputer ) 
            VALUES (
            @Id,
            @Brand,
            @Modelo,
            @RealeseYear,
            @Color,
            @DefaultCapacity,
            @MaxCapacity,
            @Processor,
            @TypeDisc,
            @DiscCapacity,
            @TypeComputer )";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(sql, computer);
                var Listcomputer = GetComputers();
                Computer compute = Listcomputer.FirstOrDefault(C => C.Id.Trim() == computer.Id.Trim());
                return compute;
            }
        }


       

        public List<Computer> GetComputers()
        {
            var sql = "SELECT Id, Brand,Modelo,RealeseYear,Color,DefaultCapacity,MaxCapacity,Processor,TypeDisc,DiscCapacity,TypeComputer FROM Computers";
            using (var connection = new SqlConnection(_connectionString))
            {
                var computers = connection.Query<Computer>(sql).ToList();
                return computers; 
            }
        }

        public Computer SaveComputer(Computer computer)
        {
           return this.Insert(computer);
        }

       
        public bool RemoveComputer(string id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"DELETE FROM Computers WHERE Id=@id";
                var affectedRows =  connection.Execute(sql, new { Id = id });
                return affectedRows > 0;
            }
        }

        public async Task<bool> UpdateComputerAsync(string Id, Computer computer)
        {
            // var sql = @"UPDATE Computers SET Id=@Id,Brand=@Brand, Modelo=@Modelo, RealeseYear=@RealeseYear, Color=@Color, DefaultCapacity=@DefaultCapacity, MaxCapacity=@MaxCapacity, Processor=@Processor, TypeDisc=@TypeDisc, DiscCapacity=@DiscCapacity, TypeComputer=@TypeComputer WHERE Id = @ID";
            // using (var connection = new SqlConnection(_connectionString)) {

            //var affectedRows = await connection.ExecuteAsync(sql, new Computer(computer.Id, computer.Brand, computer.Modelo, computer.RealeseYear, computer.Color, computer.DefaultCapacity,computer.MaxCapacity, computer.Processor,computer.TypeDisc, computer.DiscCapacity, computer.TypeComputer));//new{Id=product.Id, Title=product.Title...}
            //return affectedRows != null;
            bool remove =this.RemoveComputer(Id);
            computer.Id = Id;
            return remove && this.SaveComputer(computer) != null;
        }
        }
    }


