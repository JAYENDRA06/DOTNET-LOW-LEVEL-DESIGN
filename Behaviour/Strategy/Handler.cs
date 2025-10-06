namespace Strategy;
public class Handler {
    public static void Handle() {
        IPaymentStrategy creditCardPayment = new CreditCardPayment("1234-5678-9012-3456", "John Doe", "12/25");
        PaymentProcessor paymentProcessor = new PaymentProcessor(creditCardPayment);
        paymentProcessor.ProcessPayment(100.00m);

        IPaymentStrategy paypalPayment = new PayPalPayment("john.doe@example.com");
        paymentProcessor = new PaymentProcessor(paypalPayment);
        paymentProcessor.ProcessPayment(200.00m);
    }
}