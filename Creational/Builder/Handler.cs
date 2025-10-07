namespace Builder;

public class Handler {
    public static void Handle() {
        Car myCar = new Car.CarBuilder()
            .SetColor("Red")
            .SetEngineType("V8")
            .SetSeats(4)
            .Build();
        Console.WriteLine($"Car Details: Color={myCar.Color}, EngineType={myCar.EngineType}, Seats={myCar.Seats}");
    }
}