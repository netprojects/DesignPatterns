public interface IPaymentGatewayFactory
{
    IPaymentGateway CreatePaymentGateway();
    ITransactionLogger CreateTransactionLogger();
}