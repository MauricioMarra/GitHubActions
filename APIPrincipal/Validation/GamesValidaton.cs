using APIPrincipal.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPrincipal.Validation
{
    public class GamesValidaton : AbstractValidator<GamesRequestDto>
    {
        public GamesValidaton()
        {
            RuleFor(g => g.Nome)
                .NotEmpty()
                .NotNull();

            RuleFor(g => g.Plataforma)
                .NotEmpty()
                .NotNull();
        }
    }
}
