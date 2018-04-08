using FluentValidation.Attributes;
using MySampleCadastroProject.Domain.Customers.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySampleCadastroProject.Domain.Customers.VOs
{
    [Validator(typeof(NameModelValidator))]
    public class Name
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Name()
        {

        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

    }
}
