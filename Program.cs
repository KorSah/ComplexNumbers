using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComplexNumbers
{
    public struct Real
    {
        public double num;

        //constructor
        public Real(double num)
        {
            this.num = num;
        }

        //overloading operator (+) for two Real objects
        public static Real operator +(Real op1, Real op2)
        {
            return new Real(op1.num + op2.num);
        }

        //overloading operator (-) for two Real objects
        public static Real operator -(Real op1, Real op2)
        {
            return new Real(op1.num - op2.num);
        }

        //overloading operator (*) for two Real objects
        public static Real operator *(Real op1, Real op2)
        {
            return new Real(op1.num * op2.num);
        }

        //overloading operator (/) for two Real objects
        public static Real operator /(Real op1, Real op2)
        {
            return new Real(op1.num / op2.num);
        }

        /// <summary>
        /// overloading comparison operators
        /// </summary>
        /// <param name="op1">First comparable operand</param>
        /// <param name="op2">Second comparable operand</param>
        /// <returns>Methods return boolean values</returns>
        public static bool operator >(Real op1, Real op2)
        {
            if (op1.num > op2.num)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator >=(Real op1, Real op2)
        {
            if (op1.num >= op2.num)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator <(Real op1, Real op2)
        {
            if (op1.num < op2.num)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator <=(Real op1, Real op2)
        {
            if (op1.num <= op2.num)
            {
                return true;
            }
            else
                return false;
        }
        //Parse method parses string type to Real type
        public static Real Parse(string input)
        {
            Real instance = new Real(double.Parse(input));
            return instance;
        }

        //Override the ToString() method to display a complex number
        public override string ToString()
        {
            return num.ToString();
        }
    }

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
            if (imaginary >= new Real(0))
            {
                return (System.String.Format("{0} + {1}i", real, imaginary));
            }
            else
            {
                return (System.String.Format("{0} - {1}i", real, new Real(-1) * imaginary));
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first Real number: ");
            Real real1 = Real.Parse(Console.ReadLine());
            Console.Write("Enter the second Real number: ");
            Real imaginary1 = Real.Parse(Console.ReadLine());

            Complex complex1 = new Complex(real1, imaginary1);
            Console.WriteLine("First Complex number is: {0}", complex1);

            Console.Write("Enter the first Real number: ");
            Real real2 = Real.Parse(Console.ReadLine());
            Console.Write("Enter the second Real number: ");
            Real imaginary2 = Real.Parse(Console.ReadLine());

            Complex complex2 = new Complex(real2, imaginary2);
            Console.WriteLine("Second Complex number is: {0}", complex2);

            Complex addComplex = complex1 + complex2;
            Console.WriteLine("Sum of two Complex numbers is: {0}", addComplex);

            Complex subtComplex = complex1 - complex2;
            Console.WriteLine("Subtraction of two Complex numbers is: {0}", subtComplex);

            Console.WriteLine("Absolute value of the first Complex number is: {0}", complex1.Absolute());

            Console.WriteLine("Arctangent argument of the second Complex number is: {0}", complex2.Argument());

            Complex multyComplex = complex1 * complex2;
            Console.WriteLine("Multiplication of two Complex numbers is: {0}", multyComplex);

            Complex divComplex = complex1 / complex2;
            Console.WriteLine("Division of two Complex numbers is: {0}", divComplex);
        }
    }
}