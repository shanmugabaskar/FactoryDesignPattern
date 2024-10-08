namespace FactoryDesignPattern.CreditCard.ICardType
{
    internal interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
