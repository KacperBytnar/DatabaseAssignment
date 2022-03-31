using DatabaseAssingment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseAssingment.Interfaces
{
    public interface IApartmentService
    {
        ICollection<Apartment> GetAllApartments();
        Apartment GetApartmentByID(int id);
    }
}
