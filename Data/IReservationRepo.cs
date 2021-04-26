using System;

namespace HotelRegistration.Data
{
    public interface IReservationRepo
    {
        void MakeBooking(int roomNumber, DateTime arrival, DateTime departure);
        bool IsRoomAvailable(int roomNumber, DateTime arrival, DateTime departure);
    }
}