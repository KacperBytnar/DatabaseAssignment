using DatabaseAssingment.Interfaces;
using DatabaseAssingment.Models;
using DatabaseAssingment.Services.RentServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseAssingment.Services
{
    public class LeasingService : ILeasingService
    {
        private ADORent leasingService;

        public LeasingService(ADORent serv)
        {
            leasingService = serv;
        }
public ICollection<Leasing> GetAllLeasings()
        {
            return leasingService.GetAllRents();
        }

        public ICollection<Leasing> GetLeasingsByStudentNo(int studentNO)
        {
            return leasingService.GetLeasingByStudentNo(studentNO);
        }
    }
}
