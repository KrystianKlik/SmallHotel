using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelRegistration.Models
{
    public class Customer
    {
        public Customer()
        { 
        }
        
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public List<Reservation> Reservations { get; set; }
    }
}