using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomatedCodeTesting;

namespace TestSuiteAutomatedCodeTesting {

	[TestClass]
	public class FractionTestSuite {

		public void TestMethod0() {

		}

		[TestMethod]
		public void TestNormalValues() {
			Fraction fraction = new Fraction();
			fraction.Numerator = 100;
			fraction.Denominator = 100;
			var result = fraction.ToDecimal();
			Assert.AreEqual(1, result, "100/100");

			fraction.Numerator = 99;
			fraction.Denominator = 99;
			result = fraction.ToDecimal();
			Assert.AreEqual(1, result, "99/99");
		}
		[TestMethod]
		[ExpectedException(typeof(DivideByZeroException))]
		public void TestZeroDenominator() {
			Fraction fraction = new Fraction();
			fraction.Numerator = 0;
			fraction.Denominator = 0;
		}
	}
}
