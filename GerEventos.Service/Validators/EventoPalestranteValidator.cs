using FluentValidation;
using GerEventos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerEventos.Service.Validators
{
    public class EventoPalestranteValidator : AbstractValidator<EventoPalestrante>
{
    public EventoPalestranteValidator()
    {
        RuleFor(c => c.TituloPalestra)
            .NotEmpty().WithMessage("Por favor informe o titulo.")
            .NotNull().WithMessage("Por favor informe o titulo.");

        RuleFor(c => c.TempoDuracao)
            .NotEmpty().WithMessage("Por favor informe o tempo.")
            .NotNull().WithMessage("Por favor informe o tempo.");

            RuleFor(c => c.Evento)
            .NotEmpty().WithMessage("Por favor informe o evento.")
            .NotNull().WithMessage("Por favor informe o evento.");

            RuleFor(c => c.Palestrante)
            .NotEmpty().WithMessage("Por favor informe o palestrante.")
            .NotNull().WithMessage("Por favor informe o palestrante.");
        }
}
}
