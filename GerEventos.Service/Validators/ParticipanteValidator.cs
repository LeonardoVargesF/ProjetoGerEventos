using FluentValidation;
using GerEventos.Domain.Entities;

namespace GerEventos.Service.Validators
{
    public class ParticipanteValidator : AbstractValidator<Participante>
    {
        public ParticipanteValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");
            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Por favor informe o email.")
                .NotNull().WithMessage("Por favor informe o email.");
            RuleFor(c => c.CPF)
                .NotEmpty().WithMessage("Por favor informe o CPF.")
                .NotNull().WithMessage("Por favor informe o CPF.");
            RuleFor(c => c.Telefone)
                .NotEmpty().WithMessage("Por favor informe o telefone.")
                .NotNull().WithMessage("Por favor informe o telefone.");
            RuleFor(c => c.Cidade)
                .NotEmpty().WithMessage("Por favor informe a cidade.")
                .NotNull().WithMessage("Por favor informe a cidade.");
        }
    }
}