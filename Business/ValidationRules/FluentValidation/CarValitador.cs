using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValitador:AbstractValidator<Car>
    {
        public CarValitador()
        {
            
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.ModelYear).GreaterThan(0);
            RuleFor(c => c.Description).MinimumLength(4);
        }
    }
}
