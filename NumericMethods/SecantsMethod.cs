using System;

namespace ProjektMO.NumericMethods
{
    internal class SecantsMethod : NumericMethod
    {
        public SecantsMethod(double epsilon) : base(epsilon) { }

        public override string Name { get; } = "Secants method";
        
        public override double? SolveEquation(double firstNumber, double secondNumber)
        {
            if (Math.Abs(Function(firstNumber) - Function(secondNumber)) < 0 || Epsilon < 0)
                return null;

            double root = 0;

            while (Math.Abs(firstNumber - secondNumber) > Epsilon)
            {
                root = firstNumber - Function(firstNumber) * (firstNumber - secondNumber) / (Function(firstNumber) - Function(secondNumber));

                if (Math.Abs(Function(root)) < Epsilon)
                    return root;

                secondNumber = firstNumber;
                firstNumber = root;
            }

            return root;
        }
    }
}