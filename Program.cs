using System;
using System.Collections.Generic;
using ProjektMO.NumericMethods;

namespace ProjektMO
{
    class Program
    {
        static void Main(string[] args)
        {
            NumericMethod.PrintEquation();
            AllMethodsDemo();

            Console.ReadKey();
        }

        private static void AllMethodsDemo()
        {
            const double epsilon = 0.001;

            var numericMethods = new List<NumericMethod>()
            {
                new BisectionMethod(epsilon),
                new NewtonsMethod(epsilon),
                new RegulaFalsiMethod(epsilon),
                new SecantsMethod(epsilon)
            };

            const double a = -200, b = 300;
            Console.WriteLine("a = {0}, b = {1}, epsilon = {2}\n", a, b, epsilon);

            foreach (var numericMethod in numericMethods)
            {
                Console.WriteLine(numericMethod.Name);

                var root = numericMethod.SolveEquation(a, b);

                if (root.HasValue)
                    Console.WriteLine("Root: {0}\nError: {1}\n", root, -1-root);
                else
                    Console.WriteLine("No root has been found between values {0}, {1} with an epsilon of {2}\n", a, b, epsilon);
            }
        }
    }
}
