using HotelRegistration.Data;
using HotelRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationRepo _repository;

        public ReservationsController(IReservationRepo repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public ActionResult<bool> IsRoomAvailable([FromBody] Reservation reservation)
        {
            bool isAvailable = _repository.IsRoomAvailable(reservation.RoomNumber, reservation.Arrival, reservation.Departure);

            return Ok(isAvailable);
        }

        // [HttpPost]
        // public ActionResult<string> MakeBooking([FromBody] Reservation reservation)
        // {
        //     _repository.MakeBooking(reservation.RoomNumber, reservation.Arrival, reservation.Departure);
        //     return Ok("Booking added");
        // }
    }

}

