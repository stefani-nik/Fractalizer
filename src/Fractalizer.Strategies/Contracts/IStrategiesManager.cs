namespace Fractalizer.Strategies.Contracts
{
    public interface IStrategiesManager
    {
        INewtonEquationStrategy GetNewtonEquationStategy(string equationString);
    }
}
