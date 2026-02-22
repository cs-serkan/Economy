namespace CsSerkan.Economy
{
    public interface IEconomyService
    {
        double CurrentGold { get; }
        void AddGold(double amount);
        bool SpendGold(double amount);
    }
}