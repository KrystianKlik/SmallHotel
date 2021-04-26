using HotelRegistration.Data;
using HotelRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomRepo _repository;

        public RoomsController(IRoomRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Room>> GetAllRooms()
        {
            var rooms = _repository.GetAllRooms();

            return Ok(rooms);
        }

        [HttpGet("{roomNumber}")]
        public ActionResult<Room> GetRoom(int roomNumber)
        {
            var room = _repository.GetRoom(roomNumber);

            return Ok(room);
        }
    }

}

