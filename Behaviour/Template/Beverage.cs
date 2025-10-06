namespace Template;

abstract class Beverage {
    public void PrepareRecipe() {
        BoilWater();
        Brew();
        PourInCup();
        if (CustomerWantsCondiments()) {
            AddCondiments();
        }
    }

    protected abstract void Brew();
    protected abstract void AddCondiments();

    private void BoilWater() {
        Console.WriteLine("Boiling water");
    }

    private void PourInCup() {
        Console.WriteLine("Pouring into cup");
    }

    // Hook method
    protected virtual bool CustomerWantsCondiments() {
        return true;
    }
}

class Tea : Beverage {
    protected override void Brew() {
        Console.WriteLine("Steeping the tea");
    }

    protected override void AddCondiments() {
        Console.WriteLine("Adding lemon");
    }
}

class Coffee : Beverage {
    protected override void Brew() {
        Console.WriteLine("Dripping Coffee through filter");
    }

    protected override void AddCondiments() {
        Console.WriteLine("Adding sugar and milk");
    }

    protected override bool CustomerWantsCondiments() {
        // For demonstration, let's say the customer doesn't want condiments
        return false;
    }
}