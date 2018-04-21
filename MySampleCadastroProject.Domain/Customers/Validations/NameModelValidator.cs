using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using MySampleCadastroProject.Domain.Customers.VOs;

namespace MySampleCadastroProject.Domain.Customers.Validations
{
    public class NameModelValidator : AbstractValidator<Name>
    {
        public NameModelValidator()
        {
            Initialize();
        }

        private void Initialize()
        {
            FirstNameModelValidation();
            LastNameModelValidation();

        }

        private void FirstNameModelValidation()
        {
            RuleFor(c => c.FirstName)
                .NotNull()
                .NotEmpty()
                .WithMessage("Nome não pode ser nulo ou vazio.")
                .MaximumLength(3)
                .WithMessage("Nome precisa ter no mínimo 3 caracteres.")
                .MaximumLength(50)
                .WithMessage(" Nome não pode ter mais de 50 caracteres.");
        }

        private void LastNameModelValidation()
        {
            RuleFor(c => c.LastName)
                .NotNull()
                .NotEmpty()
                .WithMessage("Sobrenome não pode ser nulo ou vazio.")
                .MaximumLength(3)
                .WithMessage("Sobrenome precisa ter no mínimo 3 caracteres.")
                .MaximumLength(50)
                .WithMessage("Sobrenome não pode ter mais de 50 caracteres.");
        }
    }
}
