using FluentValidation;
using GerEventos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerEventos.Service.Validators
{
    public class EventoInscricaoValidator : AbstractValidator<EventoInscricao>
    {
        public EventoInscricaoValidator()
        {
            RuleFor(c => c.Evento);


            RuleFor(c => c.DataInscricao);


            RuleFor(c => c.Participante);

        }
    }
}
