using FactoryDesignPattern.CreditCard.ICardType;

namespace FactoryDesignPattern.CreditCard.CardType
{
    internal class Titanium : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium Edge";
        }
        public int GetCreditLimit()
        {
            return 25000;
        }
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }
}
