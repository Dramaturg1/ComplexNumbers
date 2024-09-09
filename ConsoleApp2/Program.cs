using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    internal class Program
    {
        public class ComplexNumber
        {
            private readonly double real;
            private readonly double imag;
            public ComplexNumber(double real, double imag)
            {
                this.real = real;
                this.imag = imag;
            }

            public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b) => new ComplexNumber(a.real + b.real, a.imag + b.imag);

            public static ComplexNumber operator -(ComplexNumber a) => new ComplexNumber(-a.real, -a.imag);

            public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b) => new ComplexNumber(a.real - b.real, a.imag - b.imag);

            public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b) => new ComplexNumber(a.real * b.real - a.imag * b.imag, a.real * b.imag + a.imag * b.real);

            public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b) => new ComplexNumber((a.real * b.real + a.imag * b.imag) / (b.real * b.real + b.imag * b.imag), (a.imag * b.real + a.real * b.imag) / (b.real * b.real + b.imag * b.imag));

            public static double Module(ComplexNumber a) => Math.Sqrt(a.real * a.real + a.imag * a.imag);

            public static double Arg(ComplexNumber a)
            {
                if (a.real > 0 && a.imag >= 0) return Math.Atan(a.imag / a.real);
                if (a.real < 0 && a.imag >= 0) return Math.PI - Math.Atan(Math.Abs(a.imag / a.real));
                if (a.real < 0 && a.imag < 0) return Math.PI + Math.Atan(Math.Abs(a.imag / a.real));
                if (a.real > 0 && a.imag < 0) return 2*Math.PI - Math.Atan(Math.Abs(a.imag / a.real));
                if (a.real == 0 && a.imag > 0) return Math.PI / 2;
                if (a.real == 0 && a.imag < 0) return 3 * Math.PI / 2;
                return double.NaN;
            }

            public static double Real(ComplexNumber a) => a.real;
            public static double Imag(ComplexNumber a) => a.imag;

            public static void Out(ComplexNumber a)
            {
                if (a.imag > 0)
                    Console.WriteLine("{0}+{1}i", a.real, a.imag);
                else if (a.imag == 0)
                    Console.WriteLine(a.real);
                else
                    Console.WriteLine("{0}{1}i", a.real, a.imag);
            }
        }

        public static ComplexNumber Parser(string input)
        {
            var pattern = @"(?<real>[-+]?\d+)(?<imag>[-+]\d+)i";
            var match = Regex.Match(input, pattern);
            if (!match.Success)
            {
                throw new FormatException("The string has an incorrect complex number statement");
            }
            double real = double.Parse(match.Groups["real"].Value);
            double imag = double.Parse(match.Groups["imag"].Value);
            return new ComplexNumber(real, imag);
            
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Choose one of the options below:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Substraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Quit");

                string symb = Console.ReadLine();

                switch(symb)
                {
                    case "1":
                        Console.WriteLine("Enter 2 complex numbers:");
                        

                }

                
            }
        }
    }
}
