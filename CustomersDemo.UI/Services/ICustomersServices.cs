using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersDemo.UI.Services
{
    public interface ICustomersServices
    {
        public Task<List<Customer>> GetAllCustomersAsync();
        public Task<Customer> GetCustomerById(Guid Id);
        public Task InsertCustomer(Customer customer);
        public Task UpdateCustomerById(Customer customer);
        public Task DeleteCustomerById(Guid Id);
        public Task<Contact> GetContactCustomerById(Guid Id);
        public Task<Address> GetAddessCustomerById(Guid Id);
    }
}
