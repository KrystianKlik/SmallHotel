using HotelRegistration.Models;
using System;
using System.Collections.Generic;

namespace HotelRegistration.Data
{
    public interface IRoomRepo
    {
        IEnumerable<Room> GetAllRooms();
        Room GetRoom(int roomNumber);
    }
}
