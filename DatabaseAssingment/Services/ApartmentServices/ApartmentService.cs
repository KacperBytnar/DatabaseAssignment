using DatabaseAssingment.Interfaces;
using DatabaseAssingment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseAssingment.Services
{
    public class ApartmentService : IApartmentService
    {
        private ADOApartment apartmentService;
        public ApartmentService(ADOApartment service)
        {
            apartmentService = service;
        }

        public ICollection<Apartment> GetAllApartments()
        {
            return apartmentService.GetAllApartments();
        }

        public Apartment GetApartmentByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
