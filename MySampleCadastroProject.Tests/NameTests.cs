using MySampleCadastroProject.Domain.Customers.Validations;
using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation.TestHelper;
using Xunit;

namespace MySampleCadastroProject.Tests
{
    public class NameTests
    {
        private readonly NameModelValidator _validator;

        public NameTests()
        {
                _validator = new NameModelValidator();
        }

        //Check if name is valid
        [Fact]
        private void ShouldPassIfFirstNameIsValid()
        {
            _validator.ShouldNotHaveValidationErrorFor(c=>c.FirstName,"Gerson");
        }

        //Check if name is null
        [Fact]
        private void ShouldPassIfFirstNameIsNull()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.FirstName, (string) null);
        }

        //Check if name is empty
        [Fact]
        private void ShouldPassIfFirstNameIsEmpty()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.FirstName, (string) "");
        }
    }
}
