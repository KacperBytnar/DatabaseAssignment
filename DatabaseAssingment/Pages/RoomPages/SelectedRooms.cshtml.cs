using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseAssingment.Interfaces;
using DatabaseAssingment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DatabaseAssingment.Pages.RoomPages
{
    public class SelectedRoomsModel : PageModel
    {
        [BindProperty]
        public IEnumerable<Room> Rooms { get; set; }
        private IRoomService roomService;


        public SelectedRoomsModel(IRoomService serv)
        {
            roomService = serv;
        }
        public void OnGet(int id, string type)
        {
            if(type=="dorm")
            {
                Rooms = roomService.GetRoomByDormitoryNo(id);
            }
            else if (type == "apart")
            {
                Rooms = roomService.GetRoomByApartmentNo(id);
            }

        }


        public IActionResult OnPost(int id)
        {
            roomService.AssignRoom(roomService.GetRoomByPlaceNo(id));
            return RedirectToPage("/RentPages/GetAllRents");
        }
    }
}
