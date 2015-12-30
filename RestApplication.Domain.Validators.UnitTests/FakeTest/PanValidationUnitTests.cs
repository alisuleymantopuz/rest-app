using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using NUnit.Framework;

namespace RestApplication.Domain.Validators.UnitTests.FakeTest
{
    [TestFixture]
    public class PanValidationUnitTests
    {
        public CreditCardNumberValidator CreditCardNumberValidator { get; private set; }

        [SetUp]
        public void Setup()
        {
            CreditCardNumberValidator = new CreditCardNumberValidator();
        }

        [Test]
        public void PanValidationUnitTests_SetRules_Method_Should_Be_Success()
        {
            this.CreditCardNumberValidator.SetRules();

            CreditCard creditCard = new CreditCard();
            //creditCard.Pan = "4242424242424242";
            //creditCard.Pan = "1111111111111111";
            creditCard.Pan = "4012001037141112";

            ValidationResult validationResult = CreditCardNumberValidator.Validate(creditCard);

            validationResult.IsValid.Should().Be(true);
        }
    }
}
