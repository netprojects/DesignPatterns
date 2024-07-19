public class PayPalGateway : IPaymentGateway
{
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing payment of {amount} with paypal");
        return true;
    }
}