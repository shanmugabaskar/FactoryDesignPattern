namespace FactoryDesignPattern.PaymentGateway.IGateway
{
    internal interface IPaymentGateway
    {
        void ProcessPayment(decimal amount);
    }
}
