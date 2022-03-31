using DatabaseAssingment.Interfaces;
using DatabaseAssingment.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseAssingment.Services.RoomServices
{
    public class ADORoom
    {
        private string connectionString;
        private IConfiguration configuration;
        private IStudentService studentService;
        public ADORoom(IConfiguration config, IStudentService serv)
        {
            studentService = serv;
            configuration = config;
            connectionString = configuration.GetConnectionString("StudentAccomodationContext");
        }

        public List<Room> GetAllRooms()
        {
            List<Room> Rooms = new List<Room>();
            string query = "select * from Room";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Room room = new Room();
                        room.Place_No = Convert.ToInt32(reader[0]);
                        room.Rent_Per_Semester = Convert.ToInt32(reader[1]);
                        room.Occupied = Convert.ToBoolean(reader[2]);
                        room.Room_No = Convert.ToInt32(reader[3]);
                        room.Dormitory_No = (Convert.IsDBNull(reader[4])) ? 0 : Convert.ToInt32(reader[4]);
                        room.Apartment_No = (Convert.IsDBNull(reader[5])) ? 0 : Convert.ToInt32(reader[5]);

                        Rooms.Add(room);
                    }
                }
                return Rooms;
            }
        }
        public List<Room> GetRoomByDormitoryNo(int dormitoryNumber)
        {
            List<Room> Rooms = new List<Room>();
            string query = $"select * from Room where Dormitory_No={dormitoryNumber} and Occupied=0";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Room room = new Room();
                        room.Place_No = Convert.ToInt32(reader[0]);
                        room.Rent_Per_Semester = Convert.ToInt32(reader[1]);
                        room.Occupied = Convert.ToBoolean(reader[2]);
                        room.Room_No = Convert.ToInt32(reader[3]);
                        room.Dormitory_No = (Convert.IsDBNull(reader[4])) ? 0 : Convert.ToInt32(reader[4]);
                        room.Apartment_No = (Convert.IsDBNull(reader[5])) ? 0 : Convert.ToInt32(reader[5]);

                        Rooms.Add(room);
                    }
                }
                return Rooms;
            }
        }
        public List<Room> GetRoomByApartmentNo(int apartmentNumber)
        {
            List<Room> Rooms = new List<Room>();
            string query = $"select * from Room where Appart_No={apartmentNumber}  and Occupied=0";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Room room = new Room();
                        room.Place_No = Convert.ToInt32(reader[0]);
                        room.Rent_Per_Semester = Convert.ToInt32(reader[1]);
                        room.Occupied = Convert.ToBoolean(reader[2]);
                        room.Room_No = Convert.ToInt32(reader[3]);
                        room.Dormitory_No = (Convert.IsDBNull(reader[4])) ? 0 : Convert.ToInt32(reader[4]);
                        room.Apartment_No = (Convert.IsDBNull(reader[5])) ? 0 : Convert.ToInt32(reader[5]);

                        Rooms.Add(room);
                    }
                }
                return Rooms;
            }
        }

        public Room GetRoomByPlaceNo(int placeNumber)
        {
            Room room = new Room();
            string query = $"select * from Room where Place_No={placeNumber}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        room.Place_No = Convert.ToInt32(reader[0]);
                        room.Rent_Per_Semester = Convert.ToInt32(reader[1]);
                        room.Occupied = Convert.ToBoolean(reader[2]);
                        room.Room_No = Convert.ToInt32(reader[3]);
                        room.Dormitory_No = (Convert.IsDBNull(reader[4])) ? 0 : Convert.ToInt32(reader[4]);
                        room.Apartment_No = (Convert.IsDBNull(reader[5])) ? 0 : Convert.ToInt32(reader[5]);

                    }
                }
                return room;
            }
        }

        public Dormitory GetDormitoryByPlaceNo(int placeNumber)
        {
            Dormitory dormitory = new Dormitory();
            string query = $"select * from Dormitory " +
                $"left join Room on Dormitory.Dormitory_No=Room.Dormitory_No " +
                $"where Room.Place_No={placeNumber}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dormitory.Dormitory_No = Convert.ToInt32(reader[0]);
                        dormitory.Address = Convert.ToString(reader[2]);
                        dormitory.Name = Convert.ToString(reader[1]);
                    }
                }
                return dormitory;
            }
        }

        public Apartment GetApartmentByPlaceNo(int placeNumber)
        {
            Apartment apartment = new Apartment();
            string query = $"select * from Appartment " +
                $"left join Room on Appartment.Appart_No=Room.Appart_No " +
                $"where Room.Place_No={placeNumber}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        apartment.Apartment_No = Convert.ToInt32(reader[0]);
                        apartment.Address = Convert.ToString(reader[1]);
                        apartment.Types = Convert.ToString(reader[2]);
                    }
                }
                return apartment;
            }
        }


        public void ChangeRoomStatus(Room room)
        {
            string query = $"update Room set Occupied={1} where Place_No={room.Place_No}"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                   command.ExecuteReader();
                }
            }
        }

        public void AssignRoom(Room room)
        {
            List<Student> waitingList = new List<Student>();
            waitingList = studentService.WaitingList().ToList<Student>();

            DateTime date_From = new DateTime(2022, 07, 01);
            DateTime date_To = new DateTime(2022, 12, 31);

            string query = $"INSERT INTO Leasing (Student_No, Place_No, Date_From, Date_To) VALUES (@Student_No, @Place_No, @Date_From, @Date_To)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Student_No", waitingList[0].Student_No);
                    command.Parameters.AddWithValue("@Place_No", room.Place_No);
                    command.Parameters.AddWithValue("@Date_From", date_From);
                    command.Parameters.AddWithValue("@Date_To", date_To);
                    
                    command.ExecuteNonQuery();
                    studentService.ChangeStatus(waitingList[0]);
                    ChangeRoomStatus(room);
                }
            }
        }
    }
}
