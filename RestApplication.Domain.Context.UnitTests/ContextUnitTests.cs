using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RestApplication.Domain.Context.UnitTests
{
    [TestFixture]
    public class ContextUnitTests
    {
        public RestApplicationContext RestApplicationContext { get; private set; }
        [SetUp]
        public void Setup()
        {
            RestApplicationContext = new RestApplicationContext();

        }

        [Test]
        public void ContextUnitTests_DatabaseGeneration_Creation_Tests()
        {
            RestApplicationContext.Database.CreateIfNotExists();
        }

        [Test]
        public void ContextUnitTests_DatabaseGeneration_Recreation_Tests()
        {
            RestApplicationContext.Database.Delete();
            RestApplicationContext.Database.CreateIfNotExists();
        }
    }
}
