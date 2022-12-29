﻿using NUnit.Framework;
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
        public void DivisionMastReturnNotZero() 
        { 
            var calculator = new Calculator();
            Assert.NotZero(calculator.Division(4, 2));
        }
        [Test]
        public void MiltiplicationMustNotReturnNullVallue () 
        {
            var calculator = new Calculator();
            Assert.That(2 * 2, Is.EqualTo(4));
        }
        [Test] public void Subtraction()
        {
            var calculator = new Calculator();
            Assert.That(10 - 5, Is.EqualTo(5));
        }
    }
}
