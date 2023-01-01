using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator() {

            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemessiniz");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori açıklamasını boş geçemessiniz");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Kategori En Fazla 50 Karakter Uzunluğunu geçemez");
            RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage("Kategori En az 2 Karakter Uzunluğunda Olmalı");
        }
    }
}
