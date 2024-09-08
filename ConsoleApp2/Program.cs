using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        class ComplexNumbers
        {
            private double real;
            private double imag;
            ComplexNumbers(double real, double imag)
            {
                this.real = real;
                this.imag = imag;
            }

            public void Init(double real, double imag)
            {
                this.real = real;
                this.imag = real;
            }

        }
        static void Main(string[] args)
        {
        }
    }
}
