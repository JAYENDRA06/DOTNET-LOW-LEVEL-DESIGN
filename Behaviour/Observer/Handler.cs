namespace Observer;

public class Handler {
    public static void Handle() {
        TechChannel techChannel = new TechChannel();
        Subscriber alice = new YoutubeSubscriber("Alice");
        Subscriber bob = new EmailSubscriber("bob@example.com");
        techChannel.Subscribe(alice);
        techChannel.Subscribe(bob);
        techChannel.UploadVideo("Observer Design Pattern");
    }
}
