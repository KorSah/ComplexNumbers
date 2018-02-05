using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    /// <summary>
    /// Real structure is a custom type for real numbers
    /// </summary>
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

        public static bool operator ==(Real op1, Real op2)
        {
            if (op1.num == op2.num)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator !=(Real op1, Real op2)
        {
            if (op1.num != op2.num)
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
}
