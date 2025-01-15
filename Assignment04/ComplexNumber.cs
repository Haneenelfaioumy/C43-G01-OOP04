using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal class ComplexNumber
    {
        #region Properties
        public double Real { get; set; }
        public double Imaginary { get; set; }
        #endregion

        #region Operator Overloading
        // Overloading the + operator for complex number addition
        public static ComplexNumber operator +(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber()
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Imaginary = (left?.Imaginary ?? 0) + (right?.Imaginary ?? 0)
            };
        }

        // Overloading the - operator for complex number subtraction
        public static ComplexNumber operator -(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber()
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Imaginary = (left?.Imaginary ?? 0) - (right?.Imaginary ?? 0)
            };
        }
        #endregion

        #region Overriding ToString() Method
        // Overriding ToString() to display the complex number in a readable format
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
        #endregion
    }
}
