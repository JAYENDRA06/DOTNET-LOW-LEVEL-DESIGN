namespace Observer;

// THEORY: allows one object(subject) to notify other dependent objects(subscribers) about state changes, promoting loose coupling.

public interface Subscriber {
    void Update(string message);
}

public class YoutubeSubscriber : Subscriber {
    private string name;

    public YoutubeSubscriber(string name) {
        this.name = name;
    }

    public void Update(string message) {
        Console.WriteLine($"{name} received youtube notification: {message}");
    }
}

public class EmailSubscriber : Subscriber {
    private string email;

    public EmailSubscriber(string email) {
        this.email = email;
    }

    public void Update(string message) {
        Console.WriteLine($"Email to {email}: {message}");
    }
}

public interface YoutubeChannel {
    void Subscribe(Subscriber subscriber);
    void Unsubscribe(Subscriber subscriber);
    void NotifySubscribers(string message);
}
public class TechChannel : YoutubeChannel {
    private List<Subscriber> subscribers = new List<Subscriber>();
    private string videoTitle = "";

    public void Subscribe(Subscriber subscriber) {
        subscribers.Add(subscriber);
    }

    public void Unsubscribe(Subscriber subscriber) {
        subscribers.Remove(subscriber);
    }

    public void NotifySubscribers(string message) {
        foreach (Subscriber subscriber in subscribers) {
            subscriber.Update(message);
        }
    }
    public void UploadVideo(string title) {
        videoTitle = title;
        NotifySubscribers($"New video uploaded: {title}");
    }
}