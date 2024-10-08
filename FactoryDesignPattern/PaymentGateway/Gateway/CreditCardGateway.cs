using FactoryDesignPattern.PaymentGateway.IGateway;

namespace FactoryDesignPattern.PaymentGateway.Gateway
{
    internal class CreditCardGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing ${amount} payment using Credit Card...");
            // Logic for direct credit card processing
        }
    }
}
