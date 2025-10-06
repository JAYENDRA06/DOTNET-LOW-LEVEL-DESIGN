namespace State;

public class Handler {
    public static void Handle() {
        TrafficLightContext trafficLight = new TrafficLightContext();
        for (int i = 0; i < 5; i++) {
            Console.WriteLine($"Traffic Light is: {trafficLight.GetColor()}");
            trafficLight.Change();
        }
    }
}