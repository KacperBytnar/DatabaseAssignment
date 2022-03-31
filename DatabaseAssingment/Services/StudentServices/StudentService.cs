using DatabaseAssingment.Interfaces;
using DatabaseAssingment.Models;
using DatabaseAssingment.Services.StudentServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseAssingment.Services
{
    public class StudentService : IStudentService
    {
        private ADOStudent studentService;

        public StudentService(ADOStudent serv)
        {
            studentService = serv;
        }

        public void ChangeStatus(Student student)
        {
            studentService.ChangeStatus(student);
        }

        public ICollection<Student> GetAllStudents()
        {
            return studentService.GetAllStudents();
        }

        public Student GetStudentById(Student student)
        {
            return studentService.GetStudentByID(student);
        }

        public ICollection<Student> WaitingList()
        {
            return studentService.WaitingList();
        }
    }
}
