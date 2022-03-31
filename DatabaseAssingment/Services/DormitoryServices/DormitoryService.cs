using DatabaseAssingment.Interfaces;
using DatabaseAssingment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseAssingment.Services
{
    public class DormitoryService : IDormitoryService
    {
        private ADODormitory dormitoryService;
        public DormitoryService(ADODormitory service)
        {
            dormitoryService = service;
        }
        public ICollection<Dormitory> GetAllDormitories()
        {
            return dormitoryService.GetAllDormitories();
        }

        public Dormitory GetDormitoryByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
