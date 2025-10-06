namespace Singleton;

public sealed class LazyLogger
{
    private static readonly Lazy<LazyLogger> _instance = new(() => new LazyLogger());

    private LazyLogger() { }

    public static LazyLogger Instance => _instance.Value;

    public string GetMessage() => "Lazy Logger instance running!";
}