using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        class ComplexNumber
        {
            private readonly double real;
            private readonly double imag;
            ComplexNumber(double real, double imag)
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
        }
        static void Main(string[] args)
        {
        }
    }
}
