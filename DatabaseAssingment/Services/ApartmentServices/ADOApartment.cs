using DatabaseAssingment.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseAssingment.Services
{
    public class ADOApartment
    {
        private string connectionString;
        private IConfiguration configuration;
        public ADOApartment(IConfiguration config)
        {
            configuration = config;
            connectionString = configuration.GetConnectionString("StudentAccomodationContext");
        }

        public List<Apartment> GetAllApartments()
        {
            List<Apartment> Apartments = new List<Apartment>();
            string query = "select * from Appartment";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Apartment apartment = new Apartment();
                        apartment.Apartment_No = Convert.ToInt32(reader[0]);
                        apartment.Address = Convert.ToString(reader[1]);
                        apartment.Types = Convert.ToString(reader[2]);

                        Apartments.Add(apartment);
                    }
                }
                return Apartments;
            }
        }
    }
}

