using System;
using Fractalizer.Common;
using Fractalizer.Strategies.Contracts;

namespace Fractalizer.Strategies.NewtonStrategies
{
    // Solves the equation p(z) = z^6 + 3z - 1
    public class Newton6DegreeStrategy : INewtonEquationStrategy
    {
        public Tuple<ComplexPoint, ComplexPoint> CalculateNextPoint(ComplexPoint z)
        {
            ComplexPoint z1 = ComplexPoint.Pow(z, 6) + ComplexPoint.Pow(z, 3) - 1;
            ComplexPoint dz = 6 * ComplexPoint.Pow(z, 5) + 3 * ComplexPoint.Pow(z, 2);
            ComplexPoint temp = z1 / dz;
            z -= temp;

            return new Tuple<ComplexPoint, ComplexPoint>(z, z1); ;
        }
    }
}
