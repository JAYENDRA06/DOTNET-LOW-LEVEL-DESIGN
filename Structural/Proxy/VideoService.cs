namespace Proxy;

// THEORY: provides a proxy for another object to control access to it, adding a layer of security or functionality.

public interface IVideoService {
    void PlayVideo(string userType, string videoTitle);
}

public class RealVideoService : IVideoService {
    public void PlayVideo(string userType, string videoTitle) {
        System.Console.WriteLine($"Playing video: {videoTitle} for {userType} user.");
    }
}

public class ProxyVideoService : IVideoService {
    private RealVideoService realVideoService = new RealVideoService();

    public void PlayVideo(string userType, string videoTitle) {
        if (userType == "Premium") {
            realVideoService.PlayVideo(userType, videoTitle);
        } else {
            System.Console.WriteLine($"Access denied. {userType} users cannot play video: {videoTitle}.");
        }
    }
}