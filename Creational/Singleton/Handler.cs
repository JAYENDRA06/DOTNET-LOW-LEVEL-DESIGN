namespace Singleton;

public class Handler {
    public static void Handle() {
        Console.WriteLine(Logger.GetInstance().GetMessage());
        Console.WriteLine(LazyLogger.Instance.GetMessage());
    }
}