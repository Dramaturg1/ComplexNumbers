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


        }
        static void Main(string[] args)
        {
        }
    }
}
