using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatedCodeTesting;

namespace TestSuiteAutomatedCodeTesting {

	[TestClass]
	public class SquaredTestSuite {


		[TestMethod]
		public void TestSquaredZero() {
			Assert.AreEqual(0, new Squared().Calculate(0));
		}
		[TestMethod] 
		public void TestSquaredNegative() {
			Assert.AreEqual(25, new Squared().Calculate(-5));
		}
		[TestMethod]
		public void TestSquaredPositive() {
			Assert.AreEqual(49, new Squared().Calculate(7));
		}
		[TestMethod]
		public void TestSquaredMinValue() {
			Assert.AreEqual(0, new Squared().Calculate(int.MinValue));
		}
		[TestMethod]
		public void TestSquaredMaxValue() {
			Assert.AreEqual(1, new Squared().Calculate(int.MaxValue));
		}
	}
}
