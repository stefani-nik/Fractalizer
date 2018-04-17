using Fractalizer.Common;
using Fractalizer.Strategies.Contracts;

namespace Fractalizer.Strategies
{
    public class Newton6DegreeStrategy : INewtonEquationStategy
    {
        public ComplexPoint CalculateNextPoint(ComplexPoint z)
        {
            ComplexPoint z1 = ComplexPoint.Pow(z, 6) + ComplexPoint.Pow(z, 3) - 1;
            ComplexPoint dz = 6 * ComplexPoint.Pow(z, 5) + 3 * ComplexPoint.Pow(z, 2);
            ComplexPoint temp = z1 / dz;
            z -= temp;

            return z;
        }
    }
}
