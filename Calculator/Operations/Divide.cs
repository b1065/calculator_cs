﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    internal class Divide : Operation
    {
        public override double action(double a, double b)
        {
            return a / b; 
        }
    }
}
