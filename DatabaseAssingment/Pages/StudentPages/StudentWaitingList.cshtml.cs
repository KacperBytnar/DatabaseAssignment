using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseAssingment.Interfaces;
using DatabaseAssingment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DatabaseAssingment.Pages.StudentPages
{
    public class StudentWaitingListModel : PageModel
    {
        private IStudentService studentService;

        public IEnumerable<Student> waitingList { get; set; }

        public StudentWaitingListModel(IStudentService serv)
        {
            studentService = serv;
        }
        public void OnGet()
        {
            waitingList = studentService.WaitingList();
        }
    }
}
