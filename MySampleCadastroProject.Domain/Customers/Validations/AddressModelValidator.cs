using FluentValidation;
using MySampleCadastroProject.Domain.Customers.VOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySampleCadastroProject.Domain.Customers.Validations
{
    public class AddressModelValidator : AbstractValidator<Address>
    {
        public AddressModelValidator()
        {
            Initialize();
        }

        private void Initialize()
        {
            StreetValidation();
            NumberValidation();
            CityValidation();
            StateValidation();
        }

        private void StreetValidation()
        {
            RuleFor(c=>c.Street)
                .NotNull()
                .NotEmpty()
                .WithMessage("Nome da rua obrigatório")
                .MinimumLength(2)
                .WithMessage("Nome da rua precisa ter pelo menos 2 caracteres")
                .MaximumLength(40)
                .WithMessage("Nome da rua pode ter no máximo 40 caracteres");
        }

        private void NumberValidation()
        {
            RuleFor(c => c.Number)
                .NotNull()
                .NotEmpty()
                .WithMessage("Numero da rua obrigatório");
        }

        private void CityValidation()
        {
            RuleFor(c => c.City)
                .NotNull()
                .NotEmpty()
                .WithMessage("Nome da cidade obrigatório")
                .MinimumLength(2)
                .WithMessage("Nome da cidade precisa ter pelo menos 2 caracteres")
                .MaximumLength(40)
                .WithMessage("Nome da cidade pode ter no máximo 40 caracteres");
        }

        private void StateValidation()
        {
            RuleFor(c => c.City)
                .NotNull()
                .NotEmpty()
                .WithMessage("Nome do estado obrigatório")
                .MinimumLength(2)
                .WithMessage("Nome do estado precisa ter pelo menos 2 caracteres")
                .MaximumLength(40)
                .WithMessage("Nome do estado pode ter no máximo 40 caracteres");
        }



    }
}
