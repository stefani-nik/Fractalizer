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

        public static Newton Instance => instance.Value;

        private Newton() { }

        private int iterations = 0;
        private readonly IStrategiesManager strategiesManager = new StrategiesManager();
        private INewtonEquationStrategy equationStrategy;

        public override int GetNextPixel(int coordX, int coordY)
        {

            double xValue = this.XStartValue + this.xOffset * coordX;
            double yValue = this.YStartValue + this.yOffset*coordY;


            ComplexPoint z = new ComplexPoint(xValue, yValue);
            ComplexPoint z1 = new ComplexPoint(1,0);
           // ComplexPoint dz = new ComplexPoint(1,0);

            int it = 0;


            if (xValue != 0 || yValue != 0)
            {
                while (it < iterations && z1.GetModulusSquared() > 0.00000001)
                {

                    Tuple<ComplexPoint, ComplexPoint> strategyResultTuple
                        = this.equationStrategy.CalculateNextPoint(z);

                    z = strategyResultTuple.Item1;
                    z1 = strategyResultTuple.Item2;
                   
                    
                    //z1 = ComplexPoint.Pow(z, 6) + ComplexPoint.Pow(z,3) - 1;
                    //dz = 6* ComplexPoint.Pow(z,5) + 3 * ComplexPoint.Pow(z, 2);
                    //ComplexPoint temp = z1 / dz;
                    //z -= temp;

                    

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