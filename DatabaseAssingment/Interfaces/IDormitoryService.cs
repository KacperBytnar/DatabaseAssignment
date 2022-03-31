using DatabaseAssingment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseAssingment.Interfaces
{
    public interface IDormitoryService
    {
        ICollection<Dormitory> GetAllDormitories();
        Dormitory GetDormitoryByID(int id);
    }
}
