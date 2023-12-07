using FluentValidation;
using GerEventos.Domain.Entities;

namespace GerEventos.Service.Validators
{
    public class EventoValidator : AbstractValidator<Evento>
    {
        public EventoValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");
            RuleFor(c => c.DataEvento)
                .NotEmpty().WithMessage("Por favor informe a data do evento.")
                .NotNull().WithMessage("Por favor informe a data do evento.");
            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("Por favor informe a descricao.")
                .NotNull().WithMessage("Por favor informe a descricao.");
            RuleFor(c => c.Cidade)
                .NotEmpty().WithMessage("Por favor informe a cidade.")
                .NotNull().WithMessage("Por favor informe a cidade.");
        }
    }
}