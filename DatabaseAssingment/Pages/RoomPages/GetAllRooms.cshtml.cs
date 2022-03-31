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
    public class GetAllRoomsModel : PageModel
    {
        private IRoomService roomService;

        public IEnumerable<Room> Rooms { get; set; }

        public GetAllRoomsModel(IRoomService serv)
        {
            roomService = serv;
        }
        public void OnGet()
        {
            Rooms = roomService.GetAllRooms();
        }
    }
}
