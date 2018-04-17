namespace Fractalizer.Strategies.Contracts
{
    public interface INewtonStrategiesManager
    {
        INewtonEquationStrategy GetNewtonEquationStategy(string equationString);
    }
}
