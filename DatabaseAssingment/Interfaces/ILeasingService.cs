using DatabaseAssingment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseAssingment.Interfaces
{
    public interface ILeasingService
    {
        ICollection<Leasing> GetAllLeasings();
        ICollection<Leasing> GetLeasingsByStudentNo(int studentNo);
    }
}
