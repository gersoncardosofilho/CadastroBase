using FluentValidation.Attributes;
using MySampleCadastroProject.Domain.Customers.Validations;
using System;

namespace MySampleCadastroProject.Domain.Customers.VOs
{
    [Validator(typeof(AddressModelValidator))]
    public class Address
    {
        public Address(string street, int number, string city, string state)
        {
            Street = street;
            Number = number;
            City = city;
            State = state;
        }

        public Address()
        {

        }

        public string Street { get; private set; }
        public int Number { get; private set; }
        public string City { get; private set; }
        public string State { get; set; }
    }
}
