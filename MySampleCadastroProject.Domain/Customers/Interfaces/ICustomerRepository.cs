using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MySampleCadastroProject.Domain.Customers.Entities;

namespace MySampleCadastroProject.Domain.Customers.Interfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomerAsync();
        Customer GetCustomerById(Guid id);
        void DeleteCustomerAsync(Guid id);
        void Save(Customer customer);
    }
}
