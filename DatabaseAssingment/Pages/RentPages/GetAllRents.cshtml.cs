using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseAssingment.Interfaces;
using DatabaseAssingment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DatabaseAssingment.Pages.RentPages
{
    public class GetAllRentsModel : PageModel
    {
        private ILeasingService leasingService;

        public IEnumerable<Leasing> Leasings { get; set; }

        public GetAllRentsModel(ILeasingService serv)
        {
            leasingService = serv;
        }
        public void OnGet()
        {
            Leasings = leasingService.GetAllLeasings();
        }

    }
}
