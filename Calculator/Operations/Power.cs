using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    internal class Power : Operation
    {
        public override double action(double a, double b)
        {
            if(b < 0 || b % 1 != 0)
            {
                throw new StackOverflowException("AAAAAAAAA");
            }
            else if (b == 0)
            {
                return 1;
            }
            else
            {
                return a * this.action(a, b - 1);
            }
        }   
    }
}
