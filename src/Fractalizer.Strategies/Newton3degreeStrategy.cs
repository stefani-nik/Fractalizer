using System;
using Fractalizer.Common;
using Fractalizer.Strategies.Contracts;

namespace Fractalizer.Strategies
{
    // // Solves the equation p(z) = z^3 - 1
    public class Newton3DegreeStrategy : INewtonEquationStrategy
    {
        public Tuple<ComplexPoint,ComplexPoint> CalculateNextPoint(ComplexPoint z)
        {
            ComplexPoint z1 = ComplexPoint.Pow(z, 3) - (double)1;
            ComplexPoint dz = 3 * ComplexPoint.Pow(z, 2);
            ComplexPoint temp = z1 / dz;
            z -= temp;

            return new Tuple<ComplexPoint, ComplexPoint>(z, z1);
        }
    }
}
