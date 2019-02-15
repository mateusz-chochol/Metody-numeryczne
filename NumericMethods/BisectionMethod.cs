using System;

namespace ProjektMO.NumericMethods
{
    internal class BisectionMethod : NumericMethod
    {
        public BisectionMethod(double epsilon) : base(epsilon) { }

        public override string Name { get; } = "Bisection method";

        public override double? SolveEquation(double firstNumber, double secondNumber)
        {
            if (Function(firstNumber) * Function(secondNumber) >= 0 || Epsilon <= 0)
                return null;

            double root = 0;

            while (Math.Abs(firstNumber - secondNumber) > Epsilon)
            {
                root = (firstNumber + secondNumber) / 2;

                if (Math.Abs(Function(root)) < Epsilon)
                    return root;

                if (Function(root) * Function(firstNumber) < 0)
                    secondNumber = root;
                else
                    firstNumber = root;
            }

            return root;
        }
    }
}