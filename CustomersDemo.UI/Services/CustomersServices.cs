using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersDemo.UI.Services
{
    public class CustomersServices : ICustomersServices
    {
        private readonly CustomersDemoContext _context;

        public CustomersServices(CustomersDemoContext context)
        {
            _context = context;
        }

        public async Task DeleteCustomerById(Guid Id)
        {
            var customer = await _context.Customers.FirstOrDefaultAsync(d => d.Id == Id);
            if(customer is null)
            {
                throw new Exception("No se pudo encontrar el Cliente");
            }
            else
            {
                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }
        }

        public Task<Address> GetAddessCustomerById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            List<Customer> customers = await _context.Customers.ToListAsync();
            return customers;
        }

        public Task<Contact> GetContactCustomerById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> GetCustomerById(Guid Id)
        {
            return await _context.Customers.FirstOrDefaultAsync(c => c.Id == Id);
        }

        public async Task InsertCustomer(Customer customer)
        {       
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCustomerById(Customer customer)
        {
            var customer1 = await _context.Customers.FirstOrDefaultAsync(d => d.Id == customer.Id);
            customer1.FirstName = customer.FirstName;
            customer1.LastName = customer.LastName;
            customer1.Age = customer.Age;
            await _context.SaveChangesAsync();
        }
    }
}
