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
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Açıklama Kısmını Boş Geçemezsiniz!!");
            RuleFor(x=>x.Description).MinimumLength(50).WithMessage("En Az 50 Karakter Olmalıdır.");
            RuleFor(x=>x.Description).MaximumLength(1500).WithMessage("En Fazla 1500 Karakter Olmalıdır.");
            RuleFor(x=>x.Image1).NotEmpty().WithMessage("Lütfen Görsel Seçiniz...");
        }
    }
}
