namespace HotelRegistration.Models
{
    public class Room
    {
        public Room()
        {

        }

        public Room(int roomNumber, BedroomsCount bedroomsCount)
        {
            RoomNumber = roomNumber;
            BedroomsCount = bedroomsCount;
        }

        // I use RoomNumber as Id for this project, but on bigger project of course int Id should be used
        public int RoomNumber { get; set; }
        public BedroomsCount BedroomsCount { get; set; }
    }
}
