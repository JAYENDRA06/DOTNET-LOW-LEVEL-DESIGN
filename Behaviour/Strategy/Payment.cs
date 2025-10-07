namespace Strategy;

// THEORY: allows to define a family of algorithms/behaviours and choose one during runtime

public interface IPaymentStrategy {
    void ProcessPayment(decimal amount);
}

public class CreditCardPayment : IPaymentStrategy {
    private string cardNumber;
    private string cardHolderName;
    private string expiryDate;

    public CreditCardPayment(string cardNumber, string cardHolderName, string expiryDate) {
        this.cardNumber = cardNumber;
        this.cardHolderName = cardHolderName;
        this.expiryDate = expiryDate;
    }

    public void ProcessPayment(decimal amount) {
        Console.WriteLine($"Processing credit card payment of {amount:C} for {cardHolderName}");
        // Add actual payment processing logic here
    }
}

public class PayPalPayment : IPaymentStrategy {
    private string email;

    public PayPalPayment(string email) {
        this.email = email;
    }

    public void ProcessPayment(decimal amount) {
        Console.WriteLine($"Processing PayPal payment of {amount:C} for {email}");
        // Add actual payment processing logic here
    }
}

public class PaymentProcessor {
    private IPaymentStrategy paymentStrategy;

    public PaymentProcessor(IPaymentStrategy paymentStrategy) {
        this.paymentStrategy = paymentStrategy;
    }

    public void ProcessPayment(decimal amount) {
        paymentStrategy.ProcessPayment(amount);
    }

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy) {
        this.paymentStrategy = paymentStrategy;
    }
}