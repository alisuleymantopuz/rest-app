using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Validators;

namespace RestApplication.Domain.Validators.UnitTests.FakeTest
{
    public class CreditCardNumberValidator : AbstractValidator<CreditCard>
    {
        public void SetRules()
        {
            this.RuleFor(x => x.Pan).SetValidator(new CreditCardValidator()).WithMessage("Credit card number is wrong format..");
        }
    }
}
