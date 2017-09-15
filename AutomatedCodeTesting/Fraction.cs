using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedCodeTesting {

	public class Fraction {

		public static string FractionClassName = "Fraction";
		public int Numerator { get; set; }

		private int _denominator;
		public int Denominator {
			get {
				return _denominator;
			}
			set {
				if(value == 0) {
					throw new DivideByZeroException("That's a dumb thing to do.");
				}
				_denominator = value;
			}
		}

		public double ToDecimal() {
			return (double)Numerator / (double)Denominator;
		}
	}
}
