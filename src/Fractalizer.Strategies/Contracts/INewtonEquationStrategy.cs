using System;
using Fractalizer.Common;

namespace Fractalizer.Strategies.Contracts
{
    public interface INewtonEquationStrategy
    {
       Tuple<ComplexPoint,ComplexPoint> CalculateNextPoint(ComplexPoint z);
    }
}
