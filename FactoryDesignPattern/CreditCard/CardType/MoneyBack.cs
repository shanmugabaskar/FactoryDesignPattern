using FactoryDesignPattern.CreditCard.ICardType;

namespace FactoryDesignPattern.CreditCard.CardType
{
    internal class MoneyBack : ICreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }
        public int GetCreditLimit()
        {
            return 15000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}
