using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomersDemo.UI
{
    public class Address
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(2)]
        public string Street { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public int ZipCode { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
