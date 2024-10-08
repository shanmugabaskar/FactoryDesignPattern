using FactoryDesignPattern.CreditCard.ICardType;

namespace FactoryDesignPattern.CreditCard.CardType
{
    internal class Platinum : ICreditCard
    {
        public string GetCardType()
        {
            return "Platinum Plus";
        }
        public int GetCreditLimit()
        {
            return 35000;
        }
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }
}
