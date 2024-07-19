public class PaymentService
{
    private readonly IPaymentGateway _paymentGateway;
    private readonly ITransactionLogger _transactionLogger;
    public PaymentService(IPaymentGatewayFactory paymentGateway)
    {
        _paymentGateway = paymentGateway.CreatePaymentGateway();
        _transactionLogger = paymentGateway.CreateTransactionLogger();
    }

    public void ProcessPayment(decimal amount)
    {
        if(_paymentGateway.ProcessPayment(amount))
        {
            _transactionLogger.LogTransaction($"Payment of {amount}, was successful");
        }
        else
        {
            _transactionLogger.LogTransaction($"Payment of {amount}, failed");
        }
    }

}