using System;
using System.ComponentModel.DataAnnotations;

namespace HotelRegistration.Models
{
    public class Reservation
    {
        public Reservation()
        { 
        }
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int RoomNumber { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
        public string SpecialRequests { get; set; }

        public bool IsSpecialRequests { get => SpecialRequests.Trim().Length > 0 ? true : false ; set{} }

    }
}