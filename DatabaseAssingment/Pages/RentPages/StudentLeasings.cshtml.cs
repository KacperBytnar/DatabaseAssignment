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
    public class StudentLeasingsModel : PageModel
    {
        private ILeasingService leasingService;
        private IRoomService roomService;
        public List<Leasing> leasings = new List<Leasing>();
        public List<Room> rooms = new List<Room>();
        public List<Dormitory> dormitories = new List<Dormitory>();
        public List<Models.Apartment> apartments = new List<Models.Apartment>();
        public StudentLeasingsModel(ILeasingService lServ, IRoomService rServ)
        {
            leasingService = lServ;
            roomService = rServ;
        }
        public void OnGet(int id)
        {
            leasings = leasingService.GetLeasingsByStudentNo(id).ToList<Leasing>();
            foreach (var leasing in leasings)
            {
                    rooms.Add(roomService.GetRoomByPlaceNo(leasing.Place_No));
                    dormitories.Add(roomService.GetDormitoryByPlaceNo(leasing.Place_No));
                    apartments.Add(roomService.GetApartmentByPlaceNo(leasing.Place_No));
            }
        }
    }
}
