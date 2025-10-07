namespace Factory;

// THEORY: factory pattern allows object creation in a centralized manner, promoting loose coupling and scalability.

public interface Vehicle {
    void start();
    void stop();
}

public class Car : Vehicle {
    public void start() {
        Console.WriteLine("Car started");
    }

    public void stop() {
        Console.WriteLine("Car stopped");
    }
}

public class Bike : Vehicle {
    public void start() {
        Console.WriteLine("Bike started");
    }

    public void stop() {
        Console.WriteLine("Bike stopped");
    }
}

public class VehicleFactory {
    public static Vehicle CreateVehicle(string type) {
        return type switch {
            "Car" => new Car(),
            "Bike" => new Bike(),
            _ => throw new ArgumentException("Invalid vehicle type")
        };
    }
}