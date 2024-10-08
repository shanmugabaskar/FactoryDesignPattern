// See https://aka.ms/new-console-template for more information
using FactoryDesignPattern.CreditCard.Factory;
using FactoryDesignPattern.CreditCard.ICardType;
using FactoryDesignPattern.DocumentConverter.Factory;
using FactoryDesignPattern.DocumentConverter.IConverter;
using FactoryDesignPattern.PaymentGateway.Factory;
using FactoryDesignPattern.PaymentGateway.IGateway;

//Credit card
ICreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");

if (cardDetails != null)
{
    Console.WriteLine("CardType : " + cardDetails.GetCardType());
    Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
    Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
}
else
{
    Console.Write("Invalid Card Type");
}
Console.ReadLine();

//paymentGateway

Console.WriteLine("Select the payment gateway (PayPal, Stripe, CreditCard): ");
string gatewayName = Console.ReadLine();
try
{
    IPaymentGateway paymentGateway = PaymentGatewayFactory.CreatePaymentGateway(gatewayName);
    paymentGateway.ProcessPayment(100.00M);  // Example amount
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
Console.ReadKey();

//Document Conversion System

Console.WriteLine("Enter the content to convert:");
string content = Console.ReadLine();
Console.WriteLine("Select the target format (DOCX, PDF, TXT):");
string format = Console.ReadLine();
try
{
    IDocumentConverter converter = DocumentConverterFactory.CreateDocumentConverter(format);
    string convertedContent = converter.Convert(content);
    Console.WriteLine($"Converted content ({converter.TargetExtension}): {convertedContent}");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
Console.ReadKey();
