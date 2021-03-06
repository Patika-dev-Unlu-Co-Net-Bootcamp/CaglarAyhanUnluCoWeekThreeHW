using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validation
{
    public class StudentValidator: AbstractValidator<Student>
    {
        public StudentValidator()
        {                   
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("İsim Boş Olamaz.");
            RuleFor(x => x.LastName).NotNull().NotEmpty().WithMessage("Soyad Boş Olamaz.");
            RuleFor(x => x.Email).NotNull().NotEmpty().WithMessage("Email boş Olamaz.");
            RuleFor(x => x.Status).NotNull().NotEmpty().WithMessage("Öğrenci durumu boş Olamaz.");
        }
    }
}
