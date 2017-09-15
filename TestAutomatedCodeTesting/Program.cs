using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatedCodeTesting;
using System.Diagnostics;

namespace TestAutomatedCodeTesting {
	class Program {


		void Test(int num, int den, double expectedValue, string testName) {
			Fraction fraction = new Fraction();
			fraction.Numerator = num;
			fraction.Denominator = den;
			var aDecimal = fraction.ToDecimal();
			var Passed = (aDecimal == -1);
			Debug.WriteLine($"{testName} test passed : {Passed}");
		}
		void Run() {
			Squared s = new Squared();
			var val = s.Calculate(int.MinValue);
			val = s.Calculate(int.MaxValue);
			var testSuite = new[] {
				new { N = -100, D = -100, E = 1, M = "Message" }
			};

			//Test(num, den, -1, $"Div {num} by {den} test passed");

			Fraction fraction = new Fraction();
			fraction.Numerator = 0;
			var Passed = false;
			try {
				fraction.Denominator = 0;
			} catch (DivideByZeroException) {
				Passed = true;
			}
			Debug.WriteLine($"The test passed : {Passed}");
		}

		static void Main(string[] args) {
			new Program().Run();
		}
	}
}
