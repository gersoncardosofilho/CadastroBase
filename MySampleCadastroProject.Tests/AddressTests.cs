using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation.TestHelper;
using MySampleCadastroProject.Domain.Customers.Validations;
using Xunit;

namespace MySampleCadastroProject.Tests
{
    public class AddressTests
    {
        private readonly AddressModelValidator _validator;

        public AddressTests()
        {
            _validator = new AddressModelValidator();
        }

        //Check if street is null
        [Fact]
        private void ShouldPassIfStreetNameIsNull()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Street, (string) null);
        }

        //Check if street is empty
        [Fact]
        private void ShouldPassIfStreetNameIsEmpty()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Street, (string) "");
        }

        //Check if street is valid
        [Fact]
        private void ShouldPassIfStreetNameIsNotEmptyOrNotNull()
        {
            _validator.ShouldNotHaveValidationErrorFor(c => c.Street, "Rua Vital");
        }

        //Check if streetnumber is not null
        [Fact]
        private void ShouldPassIfStreetNumberIsNotNotNull()
        {
            _validator.ShouldNotHaveValidationErrorFor(c => c.Number, 374);
        }

        
    }
}
