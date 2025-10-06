namespace Builder;

public class Handler {
    public static void Handle() {
        Carr myCar = new Carr.CarBuilder()
            .SetColor("Red")
            .SetEngineType("V8")
            .SetSeats(4)
            .Build();
        Console.WriteLine($"Car Details: Color={myCar.Color}, EngineType={myCar.EngineType}, Seats={myCar.Seats}");
    }
}