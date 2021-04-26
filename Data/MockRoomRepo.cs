using HotelRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelRegistration.Data
{
    public class MockRoomRepo : IRoomRepo
    {
        private readonly List<Room> _rooms = new List<Room>
            {
                new Room(1, BedroomsCount.One),
                new Room(2, BedroomsCount.One),
                new Room(3, BedroomsCount.One),
                new Room(4, BedroomsCount.One),
                new Room(5, BedroomsCount.Two),
                new Room(6, BedroomsCount.Two),
                new Room(7, BedroomsCount.Two),
                new Room(8, BedroomsCount.Three),
                new Room(9, BedroomsCount.Three),
                new Room(10, BedroomsCount.Three),
            };

        public IEnumerable<Room> GetAllRooms()
        {
            return _rooms;
        }

        public Room GetRoom(int roomNumber)
        {
            return _rooms.FirstOrDefault(x => x.RoomNumber == roomNumber);
        }
    }
}
