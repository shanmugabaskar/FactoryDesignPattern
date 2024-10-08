using FactoryDesignPattern.PaymentGateway.IGateway;

namespace FactoryDesignPattern.PaymentGateway.Gateway
{
    internal class PayPalGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing ${amount} payment through PayPal...");
            // Actual integration and logic for PayPal
        }
    }
}
