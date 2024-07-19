public class StripeTransactionLogger : ITransactionLogger
{
    public void LogTransaction(string mensaje)
    {
        Console.WriteLine($"Logging transacction Stripe {mensaje}");
    }
}