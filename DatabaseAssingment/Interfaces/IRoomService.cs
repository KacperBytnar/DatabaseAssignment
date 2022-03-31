using DatabaseAssingment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseAssingment.Interfaces
{
    public interface IRoomService
    {
        ICollection<Room> GetAllRooms();
        ICollection<Room> GetRoomByDormitoryNo(int dormitoryNumber);
        ICollection<Room> GetRoomByApartmentNo(int apartmentNumber);
        Room GetRoomByPlaceNo(int placeNumber);
        void AssignRoom(Room room);
        void ChangeStatus(Room room);
        public Apartment GetApartmentByPlaceNo(int placeNumber);
        public Dormitory GetDormitoryByPlaceNo(int placeNumber);
    }
}
