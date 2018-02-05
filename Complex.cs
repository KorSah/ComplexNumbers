using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    /// <summary>
    /// Complex type is designed for complex numbers
    /// </summary>
    public struct Complex
    {
        public Real real;
        public Real imaginary;

        // Constructor
        public Complex(Real real, Real imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        //overloading operator (+) for two Complex objects
        public static Complex operator +(Complex op1, Complex op2)
        {
            return new Complex(op1.real + op2.real, op1.imaginary + op2.imaginary);
        }

        //overloading operator (-) for two Complex objects
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.real - c2.real, c1.imaginary - c2.imaginary);
        }

        //overloading operator (*) for two Complex objects
        public static Complex operator *(Complex op1, Complex op2)
        {
            return new Complex((op1.real * op2.real - op1.imaginary * op2.imaginary), (op1.real * op2.imaginary + op1.imaginary * op2.real));
        }

        //overloading operator (/) for two Complex objects
        public static Complex operator /(Complex op1, Complex op2)
        {
            return new Complex((op1.real * op2.real + op1.imaginary * op2.imaginary) / (op2.real * op2.real + op2.imaginary * op2.imaginary),
                (new Real(0) - op1.real * op2.imaginary + op1.imaginary * op2.real) / (op2.real * op2.real + op2.imaginary * op2.imaginary));
        }

        /// <summary>
        /// Absolute method calculates the absolute value of complex number
        /// </summary>
        /// <returns>Returns type is Real</returns>
        public Real Absolute()
        {
            return new Real(Math.Sqrt(real.num * real.num + imaginary.num * imaginary.num));
        }

        /// <summary>
        /// Argument method calculates arctangent for complex number
        /// </summary>
        /// <returns></returns>
        public Real Argument()
        {
            return new Real(Math.Atan2(real.num, imaginary.num));
        }

        // Override the ToString() method to display a complex number 
        public override string ToString()
        {
            if (imaginary > new Real(0))
            {
                return (System.String.Format("{0} + {1}i", real, imaginary));
            }
            else if (imaginary == new Real(0))
            {
                return (System.String.Format("{0}", real));
            }
            else
            {
                return (System.String.Format("{0} - {1}i", real, new Real(-1) * imaginary));
            }
        }
    }
}
