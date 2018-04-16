using Fractalizer.Common;

namespace Fractalizer.Strategies.Contracts
{
    public interface INewtonEquationStategy
    {
        ComplexPoint CalculateNextPoint();
    }
}
