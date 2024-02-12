﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Complex
    {
        public double Real {  get; set; }
        public double Imag { get; set; }

        public void Add(Complex x)
        {
            Real += x.Real;
            Imag += x.Imag;
        }

        public void Subtract(Complex x)
        {
            Real -= x.Real;
            Imag -= x.Imag;
        }

        public void Multiply(Complex x)
        {
            Real *= x.Real;
            Imag *= x.Imag;
        }

        public void Divide(Complex x)
        {
            Real /= x.Real;
            Imag /= x.Imag;
        }
    }
}
