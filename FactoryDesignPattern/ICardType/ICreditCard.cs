namespace FactoryDesignPattern.ICardType
{
    internal interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
