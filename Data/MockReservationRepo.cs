using System;
using System.Collections.Generic;
using System.Linq;
using HotelRegistration.Models;

namespace HotelRegistration.Data
{
    public class MockReservationRepo : IReservationRepo
    {
        // dummy/mock reservartions
        internal IEnumerable<Reservation> reservations = new List<Reservation>()
        {
            new Reservation()
            {
                Id = 1,
                RoomNumber = 1,
                Arrival = DateTime.Now.AddDays(-5),
                Departure = DateTime.Now.AddHours(5),
                CustomerId = 1,
            },
            new Reservation()
            {
                Id = 2,
                RoomNumber = 1,
                Arrival = DateTime.Now.AddDays(1),
                Departure = DateTime.Now.AddDays(5),
                CustomerId = 2,
            },
            new Reservation()
            {
                Id = 3,
                RoomNumber = 2,
                Arrival = DateTime.Now.AddDays(1),
                Departure = DateTime.Now.AddDays(5),
                CustomerId = 3,
            },
            new Reservation()
            {
                Id = 4,
                RoomNumber = 2,
                Arrival = DateTime.Now.AddDays(-4),
                Departure = DateTime.Now.AddDays(1).AddHours(-1),
                CustomerId = 4,
            },
            new Reservation()
            {
                Id = 5,
                RoomNumber = 2,
                Arrival = DateTime.Now.AddDays(3),
                Departure = DateTime.Now.AddDays(5).AddHours(-5),
                CustomerId = 5,
            },
            new Reservation()
            {
                Id = 6,
                RoomNumber = 3,
                Arrival = DateTime.Now.AddDays(3),
                Departure = DateTime.Now.AddDays(5).AddHours(-5),
                CustomerId = 6,
            },
            new Reservation() {
                Id = 7,
                RoomNumber = 4,
                Arrival = DateTime.Now.AddDays(3),
                Departure = DateTime.Now.AddDays(5).AddHours(-5),
                CustomerId = 7,
            },
                        new Reservation()
            {
                Id = 8,
                RoomNumber = 5,
                Arrival = DateTime.Now.AddDays(-5),
                Departure = DateTime.Now.AddHours(5),
                CustomerId = 8,
            },
            new Reservation()
            {
                Id = 9,
                RoomNumber = 5,
                Arrival = DateTime.Now.AddDays(1),
                Departure = DateTime.Now.AddDays(5),
                CustomerId = 9,
            },
            new Reservation()
            {
                Id = 10,
                RoomNumber = 6,
                Arrival = DateTime.Now.AddDays(1),
                Departure = DateTime.Now.AddDays(5),
                CustomerId = 10,
            },
            new Reservation()
            {
                Id = 11,
                RoomNumber = 6,
                Arrival = DateTime.Now.AddDays(-4),
                Departure = DateTime.Now.AddDays(1).AddHours(-1),
                CustomerId = 6,
            },
            new Reservation()
            {
                Id = 12,
                RoomNumber = 6,
                Arrival = DateTime.Now.AddDays(3),
                Departure = DateTime.Now.AddDays(5).AddHours(-5),
                CustomerId = 7,
            },
            new Reservation()
            {
                Id = 13,
                RoomNumber = 7,
                Arrival = DateTime.Now.AddDays(3),
                Departure = DateTime.Now.AddDays(5).AddHours(-5),
                CustomerId = 8,
            },
            new Reservation() {
                Id = 14,
                RoomNumber = 7,
                Arrival = DateTime.Now.AddDays(3),
                Departure = DateTime.Now.AddDays(5).AddHours(-5),
                CustomerId = 1,
            },
            new Reservation() {
                Id = 15,
                RoomNumber = 8,
                Arrival = DateTime.Now.AddDays(-10),
                Departure = DateTime.Now.AddHours(-3),
                CustomerId = 2,
            },
            new Reservation() {
                Id = 16,
                RoomNumber = 9,
                Arrival = DateTime.Now,
                Departure = DateTime.Now.AddDays(1),
                CustomerId = 3,
            },
            new Reservation() {
                Id = 17,
                RoomNumber = 10,
                Arrival = DateTime.Now.AddHours(1),
                Departure = DateTime.Now.AddDays(5),
                CustomerId = 4,
            },
        };


        public bool IsRoomAvailable(int roomNumber, DateTime arrival, DateTime departure)
        {
           IEnumerable<Reservation> roomReservations = reservations.Select(x => x.RoomNumber == roomNumber) as List<Reservation>;

            foreach (Reservation reservation in roomReservations)
            {
                if(reservation.Arrival > arrival || reservation.Departure > departure) 
                    return false;
            }
            return true;
        }

        public void MakeBooking(int roomNumber, DateTime arrival, DateTime departure)
        {
            // Id normally should be fetch from db but for simplicity is just random number
            var rand = new Random();

            reservations.Append(new Reservation() {
                Id = rand.Next(),
                RoomNumber = roomNumber,
                Arrival = arrival,
                Departure = departure,
            });
        }
    }
}