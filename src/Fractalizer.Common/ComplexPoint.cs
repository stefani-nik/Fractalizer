using System;
using Fractalizer.Common.Contracts;

namespace Fractalizer.Common
{
    /// <summary>
    /// Struct which works with complex numbers and their calculations
    /// Each complex number consists of a real and imaginary part 
    /// Complex numbers are expressed in the form a + b*i
    /// </summary>
    public struct ComplexPoint : IComplexPoint
    {

        public ComplexPoint(double real, double imaginary)
        {
            this.Re = real;
            this.Im = imaginary;
        }

        public double Re { get; private set; }

        public double Im { get; private set; }


        /// <returns>The absolute value (modulus) of a complex number</returns>
        public double GetModulus()
        {
            return Math.Sqrt(this.Re * this.Re + this.Im * this.Im);
        }

        /// <summary>
        ///  Calculates the square root of a complex number
        /// </summary>
        public void Sqrt()
        {
            double temp = (this.Re * this.Re) - (this.Im * this.Im);
            this.Im = 2.0 * this.Re * this.Im;
            this.Re = temp;
        }

        /// <returns> A n-degree of a colex point </returns>
        public static ComplexPoint Pow(ComplexPoint c, double exponent)
        {
            double x = c.Re;
            double y = c.Im;

            double modulus = Math.Pow(x * x + y * y, exponent * 0.5);
            double argument = Math.Atan2(y, x) * exponent;

            c.Re = (double)(modulus * System.Math.Cos(argument));
            c.Im = (double)(modulus * System.Math.Sin(argument));

            return c;
        }

        public double GetModulusSquared()
        {
            return (double)this.Re * this.Re + this.Im * this.Im;
        }

        /// <returns>A complex point from a given string</returns>
        public static ComplexPoint GetPointFromString(string input)
        {
            string[] @params = input.Split(new char[] { ' ', 'i','+', '(', ')'}
                                        , StringSplitOptions.RemoveEmptyEntries);
            ComplexPoint c = new ComplexPoint(double.Parse(@params[0]), double.Parse(@params[1]));

            return c;
        }


        /*
         * Operators
         */

        public static ComplexPoint operator +(ComplexPoint c1, ComplexPoint c2)
        {
            return new ComplexPoint(c1.Re + c2.Re, c1.Im + c2.Im);
        }

        public static ComplexPoint operator +(ComplexPoint c, double f)
        {
            c.Re = (double)(c.Re + f);
            return c;
        }


        public static ComplexPoint operator -(ComplexPoint c, double f)
        {
            c.Re = (double)(c.Re - f);
            return c;
        }

        public static ComplexPoint operator -(ComplexPoint c1, ComplexPoint c2)
        {
            c1.Re = c1.Re - c2.Re;
            c1.Im = c1.Im - c2.Im;
            return c1;
        }

        public static ComplexPoint operator *(double f, ComplexPoint c)
        {
            c.Re = (double)(c.Re * f);
            c.Im = (double)(c.Im * f);
            return c;
        }

        public static ComplexPoint operator /(ComplexPoint c1, ComplexPoint c2)
        {
            double x = c1.Re, y = c1.Im;
            double u = c2.Re, v = c2.Im;
            double denom = u * u + v * v;

            if (denom == 0)
            {
                throw new DivideByZeroException();
            }

            c1.Re = (double)((x * u + y * v) / denom);
            c1.Im = (double)((y * u - x * v) / denom);

            return c1;
        }



    }
}