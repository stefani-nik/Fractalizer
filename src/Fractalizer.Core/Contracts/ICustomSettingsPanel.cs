namespace Fractalizer.Core.Contracts
{
    public interface ICustomSettingsPanel
    {
        string Params { get; set; }
        void Show();
    }
}
