using System;

namespace Calculator
{
    abstract class Operation
    {
        public void message()
        {
            Console.WriteLine("Provide two numbers separated by space:\n");
        }
        public abstract double action(double a, double b);
    }
}
