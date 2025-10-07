namespace Composite;

public class Handler {
    public static void Handle() {
        CompositeSmartComponent livingRoom = new("Living Room");
        CompositeSmartComponent kitchen = new("Kitchen");

        ISmartComponent ac1 = new AirConditioner("LG");
        ISmartComponent light1 = new Light("Philips");
        ISmartComponent ac2 = new AirConditioner("Samsung");
        ISmartComponent light2 = new Light("GE");

        livingRoom.AddComponent(ac1);
        livingRoom.AddComponent(light1);

        kitchen.AddComponent(ac2);
        kitchen.AddComponent(light2);

        CompositeSmartComponent home = new("Home");
        home.AddComponent(livingRoom);
        home.AddComponent(kitchen);

        home.TurnOn();
        System.Console.WriteLine();
        home.TurnOff();
    }
}