using FactoryDesignPattern.PaymentGateway.Gateway;
using FactoryDesignPattern.PaymentGateway.IGateway;

namespace FactoryDesignPattern.PaymentGateway.Factory
{
    internal class PaymentGatewayFactory
    {
        public static IPaymentGateway CreatePaymentGateway(string gatewayName)
        {
            switch (gatewayName.ToLower())
            {
                case "paypal":
                    return new PayPalGateway();
                case "stripe":
                    return new StripeGateway();
                case "creditcard":
                    return new CreditCardGateway();
                default:
                    throw new ArgumentException("Invalid payment gateway specified");
            }
        }
    }
}
