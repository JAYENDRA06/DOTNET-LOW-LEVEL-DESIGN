namespace Proxy;

public class Handler {
    public static void Handle() {
        IVideoService videoService = new ProxyVideoService();

        videoService.PlayVideo("Premium", "Inception");
        videoService.PlayVideo("Basic", "Inception");
    }
}