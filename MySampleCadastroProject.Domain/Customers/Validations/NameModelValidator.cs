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
            FirstNameValidation();
            LastNameValidation();
        }

        private void FirstNameValidation()
        {
            RuleFor(c=>c.FirstName)
                .NotEmpty()
                .NotNull()
                .WithMessage("Nome é obrigatório!")
                .MinimumLength(2)
                .WithMessage("Nome precisa ter pelo menos 2 caracteres!")
                .MaximumLength(40)
                .WithMessage("Nome pode ter no máximo 40 caracteres!");
        }

        private void LastNameValidation()
        {
            RuleFor(c => c.LastName)
                .NotEmpty()
                .NotNull()
                .WithMessage("Sobrenome é obrigatório!")
                .MinimumLength(2)
                .WithMessage("Sobrenome precisa ter pelo menos 2 caracteres!")
                .MaximumLength(40)
                .WithMessage("Sobrenome pode ter no máximo 40 caracteres!");
        }
    }
}
