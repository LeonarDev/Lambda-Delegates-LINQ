using _3_Multicast_Delegates.Services;
using System;

namespace _3_Multicast_Delegates
{
    delegate void BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            // op.Invoke(a, b);
            op(a, b); // sintaxe reduzida
        }
    }
}
