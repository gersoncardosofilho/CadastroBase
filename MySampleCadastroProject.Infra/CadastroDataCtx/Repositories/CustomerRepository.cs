using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySampleCadastroProject.Domain.Customers.Entities;
using MySampleCadastroProject.Domain.Customers.Interfaces;

namespace MySampleCadastroProject.Infra.CadastroDataCtx.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly CadastroDataContext _context;

        public CustomerRepository(CadastroDataContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetAllCustomerAsync()
        {
            return _context.Connection.Query
            return
                _context
                    .
                    .Query<Customer>("SELECT * FROM [tbCustomers]", new { });
        }

        public Customer GetCustomerById(Guid id)
        {
            return _context..QueryFirstOrDefault<Customer>("SELECT * from tbCustomers where Id = @id");
        }

        public void DeleteCustomerAsync(Guid id)
        {
            
        }

        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
