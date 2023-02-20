using System;
using Calculator.Operations;

namespace Calculator
{
    class MainProgram
    {
        static void process(Operation operation)
        {
            double a, b, output;
            operation.message();
            var data = Console.ReadLine().Split(' ');
            try
            {
                a = double.Parse(data[0]);
                b = double.Parse(data[1]);
                output = operation.action(a, b);
                Console.WriteLine("Result: {0}", output);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Provided input is incorrect");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: Provided input contains only one number");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: You cannot divide by zero!");
            }
            catch (StackOverflowException)
            {
                Console.WriteLine("Error: Do not provide negative or non-integer value to exponent");
            }
            finally
            {
                Console.Write("\nPress 'Enter' to continue...");
                while (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                }
                Console.Clear();
            }

        }

        static void Main(string[] args)
        {
            while (true) { 
                Console.WriteLine("Hello! What would you like to do today?\n1.Add numbers\n2.Substract numbers\n3.Multiply numbers\n4.Divide numbers\n5.Raise the number to the indicated power\n0.End program.\n");
                string input = Console.ReadLine();
                try
                {
                    switch (int.Parse(input))
                    {
                        case 1:
                            Add add = new Add();
                            process(add);
                            break;
                        case 2:
                            Subtract subtract = new Subtract();
                            process(subtract);
                            break;
                        case 3:
                            Multiply multiply = new Multiply();
                            process(multiply);
                            break;
                        case 4:
                            Divide divide = new Divide();
                            process(divide);
                            break;
                        case 5:
                            Power power = new Power();
                            process(power);
                            break;
                        case 0:
                            Console.WriteLine("Bye Bye!");
                            Console.Write("\nPress any key to continue...");
                            Console.ReadKey();
                            return;
                        default:
                            Console.WriteLine("Sorry, but it's not valid number.");
                            Console.Write("\nPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                catch (FormatException)
                {
                    return;
                }
            }
        }
    }
}

