using System;
using System.Collections.Generic;
using System.Linq;
using HotelRegistration.Models;

namespace HotelRegistration.Data
{
    public class MockCustomerRepo : ICustomerRepo
    {
        private IEnumerable<Reservation> _reservations;
        public MockCustomerRepo()
        {
            _reservations = new MockReservationRepo().reservations;
        }

        private List<Customer> customers = new List<Customer>()
        {
            new Customer()
            {
                Id = 1,
                FullName = "John Doe",
                PhoneNumber = "123 123 123",
            },
            new Customer()
            {
                Id = 2,
                FullName = "Allyn Lyndon",
                PhoneNumber = "123 543 543",
            },
            new Customer()
            {
                Id = 3,
                FullName = "Ali Crystal",
                PhoneNumber = "555 555 555",
            },
            new Customer()
            {
                Id = 4,
                FullName = "Alys Jayce",
                PhoneNumber = "555 555 555"
            },
            new Customer()
            {
                Id = 5,
                FullName = "Avonlea Liana",
                PhoneNumber = "111 222 333",
            }
        };
        
        public List<Customer> GetAllCustomers()
        {
            // fill reservations just for mock data, I know it's not ideal but for future implementation I would implement db so this class goes to bin
            foreach (Customer customer in customers)
            {
                customer.Reservations = _reservations.Select(x => x.CustomerId == customer.Id) as List<Reservation>;
            }
            return customers;
        }

        public Customer GetCustomer(int id)
        {
            return customers.FirstOrDefault(x => x.Id == id);
        }
    }
}