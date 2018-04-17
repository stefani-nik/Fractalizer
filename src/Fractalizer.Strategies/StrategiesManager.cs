﻿using System.Collections.Generic;
using System.Linq;
using Fractalizer.Strategies.Contracts;

namespace Fractalizer.Strategies
{
    public class StrategiesManager : IStrategiesManager
    {
        private readonly Dictionary<string, INewtonEquationStrategy> strategies;

        public StrategiesManager()
        {
            this.strategies = new Dictionary<string, INewtonEquationStrategy>
            {
                { "z^3 - 1", new Newton3DegreeStrategy() },
                { "z^3 - 2z + 2", new Newton3DegreeStrategy_2Z() },
                { "z^6 + z^3 - 1", new Newton6DegreeStrategy() }

            };
        }

        public INewtonEquationStrategy GetNewtonEquationStategy(string equationString)
        {
            return strategies[equationString] ?? strategies.FirstOrDefault().Value;
        }
    }
}
