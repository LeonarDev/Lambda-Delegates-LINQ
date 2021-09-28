using _2_Delegates.Services;
using System;

namespace _2_Delegates
{
    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOperation op2 = CalculationService.Max;

            double result = CalculationService.Square(a);
            double result2 = op(a, b);
            double result3 = op2(a, b);

            Console.WriteLine($"Square of {a} = {result}");
            Console.WriteLine($"Sum of {a} and {b} = {result2}");
            Console.WriteLine($"Max between {a} and {b} = {result3}");
        }
    }
}
