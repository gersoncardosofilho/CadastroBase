using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using MySampleCadastroProject.Domain.Customers.Entities;

namespace MySampleCadastroProject.Domain.Customers.Validations
{
    public class CustomerModelValidator : AbstractValidator<Customer>
    {
        public CustomerModelValidator()
        {
            Initialize();
        }

        private void Initialize()
        {
            EmailValidation();
            PhoneValidation();
        }

        private void EmailValidation()
        {
            RuleFor(c => c.Email)
                .NotNull()
                .NotEmpty()
                .WithMessage("Número do Cpf não pode ser nulo")
                .EmailAddress()
                .WithMessage("Endereço de email inválido");
        }

        private void PhoneValidation()
        {
            RuleFor(c => c.Phone)
                .NotNull()
                .NotEmpty()
                .WithMessage("Telefone não pode ser nulo");
        }
        
    }
}
