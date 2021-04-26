using System;
using System.Collections.Generic;
using HotelRegistration.Models;

namespace HotelRegistration.Data
{
    public interface ICustomerRepo
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomer(int id);
    }
}