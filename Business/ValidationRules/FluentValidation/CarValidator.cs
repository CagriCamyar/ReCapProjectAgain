using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c=> c.CarName).MinimumLength(4);
            RuleFor(c => c.DailyPrice).NotNull();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.CarName).Must(StartsWith).WithMessage("A ile Baslamalisiniz");
        }

        private bool StartsWith(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
