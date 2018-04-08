using FluentValidation.Attributes;
using MySampleCadastroProject.Domain.Customers.Validations;
using MySampleCadastroProject.Domain.Customers.VOs;
using System;

namespace MySampleCadastroProject.Domain.Customers.Entities
{
    [Validator(typeof(CustomerModelValidator))]
    public class Customer
    {
        public Customer(Name name, string email, string phone)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            Phone = phone;
           
        }

        public Customer()
        {

        }

        public Guid Id { get; private set; }
        public Name Name { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public Guid DocumentId { get; private set; }


    }
}
