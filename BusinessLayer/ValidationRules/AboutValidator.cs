using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklamayı boş geçmeyin");
            RuleFor(x => x.Image).NotEmpty().WithMessage("resmi yükleyiniz.");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("en az 50 karakter giriniz.");
        }
    }
}
