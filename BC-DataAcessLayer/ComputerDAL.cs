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
                var affectedRows = connection.Execute(sql, new { Id = id });
                return affectedRows > 0;
            }
        }

        public  bool UpdateComputer(Computer computer)
        {
            var sql = @"UPDATE Computers SET Brand=@Brand, Modelo=@Modelo, RealeseYear=@RealeseYear, Color=@Color, DefaultCapacity=@DefaultCapacity, MaxCapacity=@MaxCapacity, Processor=@Processor, TypeDisc=@TypeDisc, DiscCapacity=@DiscCapacity, TypeComputer=@TypeComputer WHERE Id = @Id";
            using (var connection = new SqlConnection(_connectionString)) {

                var affectedRows =  connection.Execute(sql, computer);
                return affectedRows > 0;
            }
        }
    }
    }


