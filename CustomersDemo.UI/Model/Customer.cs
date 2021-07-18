using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomersDemo.UI
{
    public class Customer
    {
        public Guid Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string LastName { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        public Contact Contact { get; set; }
    }
}

