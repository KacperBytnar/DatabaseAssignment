using DatabaseAssingment.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseAssingment.Services.StudentServices
{
    public class ADOStudent
    {
        private string connectionString;
        private IConfiguration configuration;
        public ADOStudent(IConfiguration config)
        {
            configuration = config;
            connectionString = configuration.GetConnectionString("StudentAccomodationContext");
        }

        public List<Student> GetAllStudents()
        {
            List<Student> Students = new List<Student>();
            string query = "select * from Student";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Student student = new Student();
                        student.Student_No = Convert.ToInt32(reader[0]);
                        student.SName = Convert.ToString(reader[1]);
                        student.SAddress = Convert.ToString(reader[2]);
                        student.Has_Room = Convert.ToBoolean(reader[3]);
                        student.RegistrationDate = Convert.ToDateTime(reader[4]);

                        Students.Add(student);
                    }
                }
                return Students;
            }
        }

        public List<Student> WaitingList()
        {
            List<Student> waitingList = new List<Student>();

            string query = "select * from Student where Student.Has_Room=0 order by Registration_Date asc";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Student student = new Student();
                        student.Student_No = Convert.ToInt32(reader[0]);
                        student.SName = Convert.ToString(reader[1]);
                        student.SAddress = Convert.ToString(reader[2]);
                        student.Has_Room = Convert.ToBoolean(reader[3]);
                        student.RegistrationDate = Convert.ToDateTime(reader[4]);

                        waitingList.Add(student);
                    }
                }
                return waitingList;
            }
        }

        public Student GetStudentByID(Student student)
        {
            Student studentt = new Student();
            string query = $"select * from Student where Student_No={student.Student_No}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        studentt.Student_No = Convert.ToInt32(reader[0]);
                        studentt.SName = Convert.ToString(reader[1]);
                        studentt.SAddress = Convert.ToString(reader[2]);
                        studentt.Has_Room = Convert.ToBoolean(reader[3]);
                        studentt.RegistrationDate = Convert.ToDateTime(reader[4]);
                    }
                }
                return student;
            }
        }

        public void ChangeStatus(Student student)
        {

            string query = $"update Student set Has_Room={1} where Student_No={student.Student_No}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteReader();
                    }
                }
            }
        }
    }

