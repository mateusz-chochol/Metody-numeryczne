using System;

namespace ProjektMO.NumericMethods
{
    internal class NewtonsMethod : NumericMethod
    {
        public NewtonsMethod(double epsilon) : base(epsilon) { }

        public override string Name { get; } = "Newton's method";

        public override double? SolveEquation(double firstNumber, double secondNumber)
        {
            if (Function(firstNumber) * Function(secondNumber) >= 0 || Epsilon <= 0)
                return null;

            while (Math.Abs(firstNumber - secondNumber) > Epsilon)
            {
                if (Math.Abs(Function(firstNumber)) < Epsilon)
                    return firstNumber;

                if (Math.Abs(Derivative(firstNumber)) < Epsilon)
                    return null;

                secondNumber = firstNumber;
                firstNumber -= Function(firstNumber) / Derivative(firstNumber);
            }

            return firstNumber;
        }
    }
}