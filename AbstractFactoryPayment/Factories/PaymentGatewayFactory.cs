public class PayPalGatewayFactory : IPaymentGatewayFactory
{
    public IPaymentGateway CreatePaymentGateway()
    {
        return new PayPalGateway();
    }

    public ITransactionLogger CreateTransactionLogger()
    {
        return new PaypalTransactionLogger();
    }
}