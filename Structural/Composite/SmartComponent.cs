namespace Composite;

// THEORY: allows treating individual objects and compositions of objects uniformly.

public interface ISmartComponent {
    void TurnOn();
    void TurnOff();
}

public class AirConditioner : ISmartComponent {
    private string name;

    public AirConditioner(string name) {
        this.name = name;
    }

    public void TurnOn() {
        System.Console.WriteLine($"{name} Air Conditioner is turned ON.");
    }

    public void TurnOff() {
        System.Console.WriteLine($"{name} Air Conditioner is turned OFF.");
    }
}

public class Light : ISmartComponent {
    private string name;

    public Light(string name) {
        this.name = name;
    }

    public void TurnOn() {
        System.Console.WriteLine($"{name} Light is turned ON.");
    }

    public void TurnOff() {
        System.Console.WriteLine($"{name} Light is turned OFF.");
    }
}

public class CompositeSmartComponent : ISmartComponent {
    private string name;
    private List<ISmartComponent> components = new List<ISmartComponent>();

    public CompositeSmartComponent(string name) {
        this.name = name;
    }

    public void AddComponent(ISmartComponent component) {
        components.Add(component);
    }

    public void RemoveComponent(ISmartComponent component) {
        components.Remove(component);
    }

    public void TurnOn() {
        System.Console.WriteLine($"{name} is turning ON all components:");
        foreach (var component in components) {
            component.TurnOn();
        }
    }

    public void TurnOff() {
        System.Console.WriteLine($"{name} is turning OFF all components:");
        foreach (var component in components) {
            component.TurnOff();
        }
    }
}