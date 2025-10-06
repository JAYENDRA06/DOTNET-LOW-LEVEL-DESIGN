namespace Adapter;

public class AirConditioner {
    public void ConnectViaRemote() {
        Console.WriteLine("Air Conditioner connected via remote control.");
    }
    public void StartCooling() {
        Console.WriteLine("Air Conditioner is cooling the room.");
    }
    public void StopCooling() {
        Console.WriteLine("Air Conditioner has stopped cooling.");
    }
    public void DisconnectRemote() {
        Console.WriteLine("Air Conditioner disconnected.");
    }
}

public class SmartLight {
    public void ConnectViaBluetooth() {
        Console.WriteLine("Smart Light connected via Bluetooth.");
    }
    public void TurnOn() {
        Console.WriteLine("Smart Light is turned on.");
    }
    public void TurnOff() {
        Console.WriteLine("Smart Light is turned off.");
    }
    public void DisconnectBluetooth() {
        Console.WriteLine("Smart Light disconnected.");
    }
}

public interface ISmartDevice {
    void TurnOnDevice();
    void TurnOffDevice();
}

public class AirConditionerAdapter : ISmartDevice {
    private AirConditioner airConditioner;

    public AirConditionerAdapter(AirConditioner ac) {
        airConditioner = ac;
    }

    public void TurnOnDevice() {
        airConditioner.ConnectViaRemote();
        airConditioner.StartCooling();
    }

    public void TurnOffDevice() {
        airConditioner.StopCooling();
        airConditioner.DisconnectRemote();
    }
}

public class SmartLightAdapter : ISmartDevice {
    private SmartLight smartLight;

    public SmartLightAdapter(SmartLight sl) {
        smartLight = sl;
    }

    public void TurnOnDevice() {
        smartLight.ConnectViaBluetooth();
        smartLight.TurnOn();
    }

    public void TurnOffDevice() {
        smartLight.TurnOff();
        smartLight.DisconnectBluetooth();
    }
}

public class SmartHome {
    private List<ISmartDevice> devices = new List<ISmartDevice>();

    public void AddDevice(ISmartDevice device) {
        devices.Add(device);
    }

    public void TurnOnAllDevices() {
        foreach (var device in devices) {
            device.TurnOnDevice();
        }
    }

    public void TurnOffAllDevices() {
        foreach (var device in devices) {
            device.TurnOffDevice();
        }
    }
}