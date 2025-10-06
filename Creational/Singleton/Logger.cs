namespace Singleton;

public sealed class Logger
{
    public static volatile Logger? _instance = null;

    private Logger() { }

    public static Logger GetInstance() {
        if (_instance == null) {
            lock (typeof(Logger)) {
                if (_instance == null) {
                    _instance = new Logger();
                }
            }
        }
        return _instance;
    }

    public string GetMessage() => "Logger instance running!";
}