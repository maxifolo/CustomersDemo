using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomersDemo.Model.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public int CellPhone { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
