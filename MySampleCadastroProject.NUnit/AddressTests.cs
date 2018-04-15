using System.IO;
using MySampleCadastroProject.Domain.Customers.Validations;
using MySampleCadastroProject.Domain.Customers.VOs;
using NUnit.Framework;
using FluentValidation.TestHelper;
using MySampleCadastroProject.Shared;

namespace MySampleCadastroProject.NUnit
{
    [TestFixture]
    public class AddressTests
    {

        private AddressModelValidator _validator;

        public AddressTests()
        {
                _validator = new AddressModelValidator();
        }

        #region ValidTests

        [Test]
        [TestCase("Rua Vital", 374, "Rio de Janeiro", "RJ")]
        public void ShouldPassIfAddressIsValid(string street, int number, string city, string state)
        {
            _validator.ShouldNotHaveValidationErrorFor(address=>address.Street, street);
            _validator.ShouldNotHaveValidationErrorFor(address=>address.Number, number);
            _validator.ShouldNotHaveValidationErrorFor(address => address.City, city);
            _validator.ShouldNotHaveValidationErrorFor(address => address.State, state);
        }

        #endregion

    }
}