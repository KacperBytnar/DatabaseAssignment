using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseAssingment.Interfaces;
using DatabaseAssingment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DatabaseAssingment.Pages.DormitoryPages
{
    public class GetAlDormitoriesModel : PageModel
    {
        private IDormitoryService dormitoryService;

        public IEnumerable<Dormitory> Dormitories { get; set; }

        public GetAlDormitoriesModel(IDormitoryService serv)
        {
            dormitoryService = serv;
        }
        public void OnGet()
        {
            Dormitories = dormitoryService.GetAllDormitories();
        }
    }
}
