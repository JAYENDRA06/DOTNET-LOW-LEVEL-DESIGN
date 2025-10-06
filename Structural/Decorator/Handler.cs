namespace Decorator;

public class Handler {
    public static void Handle() {
        ICoffee espresso = new Espresso();
        Console.WriteLine($"Order: {espresso.GetDescription()} | Cost: ${espresso.GetCost():0.00}");

        ICoffee milkCoffee = new MilkDecorator(espresso);
        Console.WriteLine($"Order: {milkCoffee.GetDescription()} | Cost: ${milkCoffee.GetCost():0.00}");

        ICoffee sugarMilkCoffee = new SugarDecorator(milkCoffee);
        Console.WriteLine($"Order: {sugarMilkCoffee.GetDescription()} | Cost: ${sugarMilkCoffee.GetCost():0.00}");

        ICoffee fancyCoffee = new WhippedCreamDecorator(sugarMilkCoffee);
        Console.WriteLine($"Order: {fancyCoffee.GetDescription()} | Cost: ${fancyCoffee.GetCost():0.00}");
    }
}