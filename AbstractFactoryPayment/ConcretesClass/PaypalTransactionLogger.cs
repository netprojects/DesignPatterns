public class PaypalTransactionLogger : ITransactionLogger
{
    public void LogTransaction(string mensaje)
    {
       Console.WriteLine($"Logging transacction PAYPAL {mensaje}");
    }
}