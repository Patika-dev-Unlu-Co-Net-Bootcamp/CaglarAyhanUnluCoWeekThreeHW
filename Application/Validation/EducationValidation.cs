using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validation
{
   public class EducationValidation: AbstractValidator<Education>
    {
        public EducationValidation()
        {
            RuleFor(x => x.EducationName).NotNull().NotEmpty().WithMessage("Eğitim adı boş Olamaz.");
            RuleFor(x => x.Capacity).NotNull().NotEmpty().WithMessage("Kapasite Boş Olamaz.");
            RuleFor(x => x.Companies).NotNull().NotEmpty().WithMessage("Firma İsmi Boş Olamaz.");
        }
    }
}
