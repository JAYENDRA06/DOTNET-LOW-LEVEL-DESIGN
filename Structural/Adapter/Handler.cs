namespace Adapter;

public class Handler {
    public static void Handle() {
        SmartHome smartHome = new SmartHome();

        AirConditioner ac = new AirConditioner();
        SmartLight sl = new SmartLight();

        ISmartDevice acAdapter = new AirConditionerAdapter(ac);
        ISmartDevice slAdapter = new SmartLightAdapter(sl);

        smartHome.AddDevice(acAdapter);
        smartHome.AddDevice(slAdapter);

        Console.WriteLine("\nTurning on all smart devices...");
        smartHome.TurnOnAllDevices();

        Console.WriteLine("\nTurning off all smart devices...");
        smartHome.TurnOffAllDevices();
    }
}