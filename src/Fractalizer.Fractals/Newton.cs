using System;
using Fractalizer.Common;
using Fractalizer.Fractals.Contracts;
using Fractalizer.Strategies;
using Fractalizer.Strategies.Contracts;

namespace Fractalizer.Fractals
{

    public sealed class Newton : Fractal, IFractalStrategy
    {

        private static readonly Lazy<Newton> instance =
                                new Lazy<Newton>(() => new Newton());

        private Newton() { }

        private int iterations = 0;
        private readonly INewtonStrategiesManager strategiesManager = new NewtonStrategiesManager();
        private INewtonEquationStrategy equationStrategy;

        public static Newton Instance => instance.Value;


        public override int GetNextPixel(int coordX, int coordY)
        {

            double xValue = this.XStartValue + this.xOffset * coordX;
            double yValue = this.YStartValue + this.yOffset * coordY;


            ComplexPoint z = new ComplexPoint(xValue, yValue);
            ComplexPoint z1 = new ComplexPoint(1, 0);

            int it = 0;

            double tolerance = 0.000000001;

            if (Math.Abs(xValue) > tolerance || Math.Abs(yValue) > tolerance)
            {
                while (it < iterations && z1.GetModulusSquared() > 0.000000001)
                {

                    Tuple<ComplexPoint, ComplexPoint> strategyResultTuple
                        = this.equationStrategy.CalculateNextPoint(z);

                    z = strategyResultTuple.Item1;
                    z1 = strategyResultTuple.Item2;
                    it++;
                }
            }


            return it;
        }

        public override void SetCustomParameters(int it, string parameters = null)
        {
            this.iterations = it;
            this.equationStrategy = this.strategiesManager.GetNewtonEquationStategy(parameters);
        }

    }
}