using System;

namespace ProjektMO
{
    internal abstract class NumericMethod
    {
        protected NumericMethod(double epsilon)
        {
            Epsilon = epsilon;
        }

        public abstract string Name { get; }

        protected static double Epsilon { get; set; }
        
        public static void PrintEquation() => Console.WriteLine("f(x) = x^3 - x^2 + 2");

        public abstract double? SolveEquation(double firstNumber, double secondNumber);

        protected static double Function(double x)
        {
            return x * x * x - x * x + 2;
        }

        protected static double Derivative(double x)
        {
            return 3 * x * x - 2 * x;
        }
    }
}