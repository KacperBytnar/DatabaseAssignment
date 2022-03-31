using DatabaseAssingment.Interfaces;
using DatabaseAssingment.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseAssingment.Services.RentServices
{
    public class ADORent
    {
        private string connectionString;
        private IConfiguration configuration;
        public ADORent(IConfiguration config)
        {
            configuration = config;
            connectionString = configuration.GetConnectionString("StudentAccomodationContext");
        }

        public List<Leasing> GetAllRents()
        {
            List<Leasing> Leasings = new List<Leasing>();
            string query = "select * from Leasing";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Leasing leasing = new Leasing();
                        leasing.Leasing_No = Convert.ToInt32(reader[0]);
                        leasing.Student_No = Convert.ToInt32(reader[1]);
                        leasing.Place_No = Convert.ToInt32(reader[2]);
                        leasing.DateFrom = Convert.ToDateTime(reader[3]);
                        leasing.DateTo = Convert.ToDateTime(reader[4]);

                        Leasings.Add(leasing);
                    }
                }
                return Leasings;
            }
        }

        public List<Leasing> GetLeasingByStudentNo(int studentNo)
        {
            List<Leasing> Leasings = new List<Leasing>();
            string query = $"select * from Leasing where Student_No={studentNo}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Leasing leasing = new Leasing();
                        leasing.Leasing_No = Convert.ToInt32(reader[0]);
                        leasing.Student_No = Convert.ToInt32(reader[1]);
                        leasing.Place_No = Convert.ToInt32(reader[2]);
                        leasing.DateFrom = Convert.ToDateTime(reader[3]);
                        leasing.DateTo = Convert.ToDateTime(reader[4]);

                        Leasings.Add(leasing);
                    }
                }
                return Leasings;
            }
        }

    }
}
