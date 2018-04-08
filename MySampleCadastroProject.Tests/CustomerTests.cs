using MySampleCadastroProject.Domain.Customers.Validations;
using FluentValidation.TestHelper;
using Xunit;

namespace MySampleCadastroProject.Tests
{
    public class CustomerTests
    {
        private readonly CustomerModelValidator _validator;

        public CustomerTests()
        {
            _validator = new CustomerModelValidator();
        }

        //Check if email is valid
        [Fact]
        public void ShouldPassIfEmailIsValid()
        {
            _validator.ShouldNotHaveValidationErrorFor(c=>c.Email, "gersoncfilho@mac.com");
        }

        //Check if Email is invalid
        [Fact]
        public void ShoulPassIfEmailIsInvalid()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Email, "gersoncfilho.com");
        }


        //Check if phone is valid
        [Fact]
        public void ShouldPassIfPhoneIsValid()
        {
            _validator.ShouldNotHaveValidationErrorFor(c=>c.Phone,"2546-6566");
        }


        //Check is phone is empty
        [Fact]
        public void ShouldPassIfPhoneIsEmpty()
        {
            _validator.ShouldHaveValidationErrorFor(c=>c.Phone, (string) "");
        }

        //Check is phone is null
        [Fact]
        public void ShouldPassIfPhoneIsNull()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.Phone, (string) null);
        }
    }
}
