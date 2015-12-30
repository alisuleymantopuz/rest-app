using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApplication.Domain.Validators.UnitTests.FakeTest
{
    public class CreditCard
    {
        public string Pan { get; set; }
        public string Expiry { get; set; }
        public string Cvv { get; set; }
    }
}
