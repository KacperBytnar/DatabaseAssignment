using DatabaseAssingment.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseAssingment.Services
{
    public class ADODormitory
    {
        private string connectionString;
        private IConfiguration configuration;
        public ADODormitory(IConfiguration config)
        {
            configuration = config;
            connectionString = configuration.GetConnectionString("StudentAccomodationContext");
        }

        public List<Dormitory> GetAllDormitories()
        {
            List<Dormitory> Dormitories = new List<Dormitory>();
            string query = "select * from Dormitory";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Dormitory dormitory = new Dormitory();
                        dormitory.Dormitory_No = Convert.ToInt32(reader[0]);
                        dormitory.Name = Convert.ToString(reader[1]);
                        dormitory.Address = Convert.ToString(reader[2]);

                        Dormitories.Add(dormitory);
                    }
                }
                return Dormitories;
            }
        }

        public List<Dormitory> GetDormitoryByID(int id)
        {
            List<Dormitory> Dormitories = new List<Dormitory>();
            string query = $"select * from Dormitory where Dormitory_No={id}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Dormitory dormitory = new Dormitory();
                        dormitory.Dormitory_No = Convert.ToInt32(reader[0]);
                        dormitory.Name = Convert.ToString(reader[1]);
                        dormitory.Address = Convert.ToString(reader[2]);

                        Dormitories.Add(dormitory);
                    }
                }
                return Dormitories;
            }
        }
    }
}
