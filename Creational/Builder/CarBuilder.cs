namespace Builder;

// THEORY: helps constructing complex objects step by step, providing better control over the construction process.
// useful in cases where huge combinations of constructor overloads would be needed.

public class Car {
    public string Color { get; private set; }
    public string EngineType { get; private set; }
    public int Seats { get; private set; }

    public Car(CarBuilder builder) {
        Color = builder.Color;
        EngineType = builder.EngineType;
        Seats = builder.Seats;
    }

    public class CarBuilder {
        public string Color { get; private set; } = "";
        public string EngineType { get; private set; } = "";
        public int Seats { get; private set; } = 0;

        public CarBuilder SetColor(string color) {
            Color = color;
            return this;
        }

        public CarBuilder SetEngineType(string engineType) {
            EngineType = engineType;
            return this;
        }

        public CarBuilder SetSeats(int seats) {
            Seats = seats;
            return this;
        }

        public Car Build() {
            return new Car(this);
        }
    }
}