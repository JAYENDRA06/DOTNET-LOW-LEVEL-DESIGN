namespace Template;

public class Handler {
    public static void Handle() {
        Beverage tea = new Tea();
        Beverage coffee = new Coffee();

        Console.WriteLine("\nPreparing tea...");
        tea.PrepareRecipe();

        Console.WriteLine("\nPreparing coffee...");
        coffee.PrepareRecipe();
    }
}