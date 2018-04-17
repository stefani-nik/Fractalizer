using Fractalizer.Common;
using Fractalizer.Strategies.Contracts;

namespace Fractalizer.Strategies
{
    // // Solves the equation p(z) = z^3 - 2
    public class Newton3DegreeStrategy_0Z : INewtonEquationStategy
    {
        public ComplexPoint CalculateNextPoint(ComplexPoint z)
        {
            ComplexPoint z1 = ComplexPoint.Pow(z, 3) - (double)2;
            ComplexPoint dz = 3 * ComplexPoint.Pow(z, 2);
            ComplexPoint temp = z1 / dz;
            z -= temp;

            return z;
        }
    }
}
