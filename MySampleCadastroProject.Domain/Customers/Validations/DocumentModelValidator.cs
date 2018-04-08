using FluentValidation;
using MySampleCadastroProject.Domain.Customers.VOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySampleCadastroProject.Domain.Customers.Validations
{
    public class DocumentModelValidator : AbstractValidator<Document>
    {
        public DocumentModelValidator()
        {
            Initialize();
        }

        private void Initialize()
        {
            DataExpedicaoValidation();
            DocumentNumberValidation();

        }

        private void DataExpedicaoValidation()
        {
            RuleFor(c=>c.DataExpedicao)
                .NotNull()
                .NotEmpty()
                .WithMessage("Data de expedição não pode ser nula")
                .LessThan(DateTime.Now)
                .WithMessage("Data de expedição não pode ser maior que data atual");
        }

        private void DocumentNumberValidation()
        {
            RuleFor(c => c.DocumentNumber)
                .NotNull()
                .NotEmpty()
                .WithMessage("Número do documento não pode ser nulo")
                .Matches(@"\+?(\d+(\.(\d+)?)?|\.\d+)")
                .WithMessage("Somente caracteres numéricos"); ;
        }



    }
}
