using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation.TestHelper;
using MySampleCadastroProject.Domain.Customers.Validations;
using Xunit;

namespace MySampleCadastroProject.Tests
{
    public class DocumentTests
    {
        private readonly DocumentModelValidator _validator;

        public DocumentTests()
        {
            _validator = new DocumentModelValidator();
        }

        //Check if data de expedicao is greater then current date
        [Fact]
        private void ShoudPassIfDataExpedicaoMaiorQueAtual()
        {
            _validator.ShouldHaveValidationErrorFor(c=>c.DataExpedicao, new DateTime(2020,10,10));
        }

        //Check if data de expedicao is less then current date
        [Fact]
        private void ShoudPassIfDataExpedicaoMenorQueAtual()
        {
            _validator.ShouldNotHaveValidationErrorFor(c => c.DataExpedicao, new DateTime(2000, 10, 10));
        }

        //Check if document number is NULL
        [Fact]
        private void ShoudPassIfDocumentNumberIsNull()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.DocumentNumber, (string) null);
        }

        //Check if document number is empty
        [Fact]
        private void ShoudPassIfDocumentNumberIsEmpty()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.DocumentNumber, (string) "");
        }

        //Check if document number is only numbers
        [Fact]
        private void ShoudPassIfDocumentNumberIsOnlyFormedByNumbers()
        {
            _validator.ShouldNotHaveValidationErrorFor(c => c.DocumentNumber, "123456789");
        }

        //Check if document number has special characteres
        [Fact]
        private void ShoudPassIfDocumentNumberHaveAlphanumerics()
        {
            _validator.ShouldHaveValidationErrorFor(c => c.DocumentNumber, "125AAA5457218");
        }
    }
}
