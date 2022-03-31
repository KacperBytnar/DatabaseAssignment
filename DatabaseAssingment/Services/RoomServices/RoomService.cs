using DatabaseAssingment.Interfaces;
using DatabaseAssingment.Models;
using DatabaseAssingment.Services.RoomServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseAssingment.Services
{
    public class RoomService : IRoomService
    {
        private ADORoom roomService;
        public RoomService(ADORoom serv)
        {
            roomService = serv;
        }

        public void AssignRoom(Room room)
        {
            roomService.AssignRoom(room);
        }

        public void ChangeStatus(Room room)
        {
            roomService.ChangeRoomStatus(room);
        }

        public ICollection<Room> GetAllRooms()
        {
            return roomService.GetAllRooms();
        }

        public Apartment GetApartmentByPlaceNo(int placeNumber)
        {
            return roomService.GetApartmentByPlaceNo(placeNumber);
        }

        public Dormitory GetDormitoryByPlaceNo(int placeNumber)
        {
            return roomService.GetDormitoryByPlaceNo(placeNumber);
        }

        public ICollection<Room> GetRoomByApartmentNo(int apartmentNumber)
        {
            return roomService.GetRoomByApartmentNo(apartmentNumber);
        }

        public ICollection<Room> GetRoomByDormitoryNo(int dormitoryNumber)
        {
            return roomService.GetRoomByDormitoryNo(dormitoryNumber);
        }

        public Room GetRoomByPlaceNo(int placeNumber)
        {
            return roomService.GetRoomByPlaceNo(placeNumber);
        }
    }
}
