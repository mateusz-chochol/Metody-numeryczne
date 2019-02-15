using System;

namespace ProjektMO.NumericMethods
{
    internal class RegulaFalsiMethod : NumericMethod
    {
        public RegulaFalsiMethod(double epsilon) : base(epsilon) { }

        public override string Name { get; } = "Regula Falsi method";

        public override double? SolveEquation(double firstNumber, double secondNumber)
        {
            if (Function(firstNumber) * Function(secondNumber) >= 0 || Epsilon <= 0)
                return null;

            double root = 0;

            while (Math.Abs(firstNumber - secondNumber) > Epsilon)
            {
                root = firstNumber - Function(firstNumber) * (secondNumber - firstNumber) / (Function(secondNumber) - Function(firstNumber));

                if (Math.Abs(Function(root)) < Epsilon)
                    return root;

                if (Function(firstNumber) * Function(root) < 0)
                    secondNumber = root;
                else
                    firstNumber = root;
            }

            return root;
        }
    }
}