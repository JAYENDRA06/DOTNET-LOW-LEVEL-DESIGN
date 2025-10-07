namespace Decorator;

// THEORY: dynamically adds behavior to objects without altering their structure.

public interface ICoffee {
    string GetDescription();
    double GetCost();
}

public class Espresso : ICoffee {
    public string GetDescription() {
        return "Espresso";
    }

    public double GetCost() {
        return 2.0;
    }
}

public class Cappuccino : ICoffee {
    public string GetDescription() {
        return "Cappuccino";
    }

    public double GetCost() {
        return 3.0;
    }
}

public abstract class CoffeeDecorator : ICoffee {
    protected ICoffee coffee;

    public CoffeeDecorator(ICoffee coffee) {
        this.coffee = coffee;
    }

    public virtual string GetDescription() {
        return coffee.GetDescription();
    }

    public virtual double GetCost() {
        return coffee.GetCost();
    }
}

public class MilkDecorator : CoffeeDecorator {
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() {
        return coffee.GetDescription() + ", Milk";
    }

    public override double GetCost() {
        return coffee.GetCost() + 0.5;
    }
}

public class SugarDecorator : CoffeeDecorator {
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() {
        return coffee.GetDescription() + ", Sugar";
    }

    public override double GetCost() {
        return coffee.GetCost() + 0.2;
    }
}

public class WhippedCreamDecorator : CoffeeDecorator {
    public WhippedCreamDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() {
        return coffee.GetDescription() + ", Whipped Cream";
    }

    public override double GetCost() {
        return coffee.GetCost() + 0.7;
    }
}