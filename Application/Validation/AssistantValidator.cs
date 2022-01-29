using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validation
{
    public class AssistantValidator: AbstractValidator<Assistant>
    {
        public AssistantValidator()
        {
            RuleFor(x => x.Email).NotNull().NotEmpty().WithMessage("Email boş Olamaz.");
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("İsim Boş Olamaz.");
            RuleFor(x => x.LastName).NotNull().NotEmpty().WithMessage("Soyad Boş Olamaz.");
        }
    }
}
