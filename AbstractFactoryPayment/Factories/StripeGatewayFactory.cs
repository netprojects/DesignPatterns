public class StripeGatewayFactory : IPaymentGatewayFactory
{
    public IPaymentGateway CreatePaymentGateway()
    {
       return new StripeGateway();
    }

    public ITransactionLogger CreateTransactionLogger()
    {
        return new StripeTransactionLogger();
    }
}