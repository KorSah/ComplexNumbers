using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComplexNumbers
{
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