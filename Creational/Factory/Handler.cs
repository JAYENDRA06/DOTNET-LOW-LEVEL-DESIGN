namespace Factory;

public class Handler {
    public static void Handle() {
        Vehicle car = VehicleFactory.CreateVehicle("Car");
        car.start();
        car.stop();

        Vehicle bike = VehicleFactory.CreateVehicle("Bike");
        bike.start();
        bike.stop();
    }
}