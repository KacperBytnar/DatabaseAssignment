using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseAssingment.Models;
using DatabaseAssingment.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DatabaseAssingment.Pages.Apartment
{
    public class GetAllApartmentsModel : PageModel
    {
        private IApartmentService apartmentService;

        public IEnumerable<Models.Apartment> Apartments { get; set; }

        public GetAllApartmentsModel(IApartmentService serv)
        {
            apartmentService = serv;
        }

        public void OnGet()
        {
            Apartments = apartmentService.GetAllApartments();
        }
    }
}
