using HotelRegistration.Data;
using HotelRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepo _repository;

        public CustomersController(ICustomerRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetAllCustomers([FromBody] Reservation reservation)
        {
            IEnumerable<Customer> customers = _repository.GetAllCustomers();
            return Ok(customers);
        }

        [HttpPost]
        public ActionResult<Customer> MakeBooking(int customerId)
        {
           Customer customer = _repository.GetCustomer(customerId);
            return Ok(customer);
        }
    }

}

