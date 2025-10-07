namespace State;

// THEORY: allows an object to alter its behavior when its internal state changes. Encapsulates state-specific behavior into separate classes.

public interface TrafficLightState {
    void Next(TrafficLightContext context);
    string GetColor();
}

class RedState : TrafficLightState {
    public void Next(TrafficLightContext context) {
        context.SetState(new GreenState());
    }

    public string GetColor() {
        return "Red";
    }
}

class GreenState : TrafficLightState {
    public void Next(TrafficLightContext context) {
        context.SetState(new YellowState());
    }

    public string GetColor() {
        return "Green";
    }
}

class YellowState : TrafficLightState {
    public void Next(TrafficLightContext context) {
        context.SetState(new RedState());
    }

    public string GetColor() {
        return "Yellow";
    }
}

public class TrafficLightContext {
    private TrafficLightState state;

    public TrafficLightContext() {
        state = new RedState();
    }

    public void SetState(TrafficLightState state) {
        this.state = state;
    }

    public void Change() {
        state.Next(this);
    }

    public string GetColor() {
        return state.GetColor();
    }
}
