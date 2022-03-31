using DatabaseAssingment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseAssingment.Interfaces
{
    public interface IStudentService
    {
        ICollection<Student> GetAllStudents();
        ICollection<Student> WaitingList();
        void ChangeStatus(Student student);
        Student GetStudentById(Student student);
    }
}
