using System;
using Fractalizer.Common;
using Fractalizer.Strategies.Contracts;

namespace Fractalizer.Strategies.NewtonStrategies
{
    // Solves the equation p(z) = z^3 - 2z + 2
    public class Newton3DegreeStrategy_2Z : INewtonEquationStrategy
    {
        public Tuple<ComplexPoint,ComplexPoint> CalculateNextPoint(ComplexPoint z)
        {
            ComplexPoint z1 = ComplexPoint.Pow(z, 3) - (2 * z) + 2.0;
            ComplexPoint dz = 3 * ComplexPoint.Pow(z, 2) - 2.0;
            ComplexPoint temp = z1 / dz;
            z -= temp;

            return new Tuple<ComplexPoint, ComplexPoint>(z, z1);
        }
    }
}
