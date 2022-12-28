using NUnit.Framework;
using Practices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustNotNullVallue()
        {
            var calculator = new Calculator();
            Assert.AreEqual(80, calculator.Additional(50, 30));
        }
        [Test]
        public void SubtractionlMustNotNullVallue() 
        { 
            var calculator = new Calculator();
            Assert.That
        }
    }
}
