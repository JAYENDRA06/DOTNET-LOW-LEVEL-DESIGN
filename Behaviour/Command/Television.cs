namespace Command;

public interface Command {
    void execute();
}

public class Television {
    public void TurnOn() {
        Console.WriteLine("Television is now ON");
    }

    public void TurnOff() {
        Console.WriteLine("Television is now OFF");
    }
}

public class TurnOnCommand: Command {
    private Television television;

    public TurnOnCommand(Television television) {
        this.television = television;
    }

    public void execute() {
        television.TurnOn();
    }
}

public class TurnOffCommand: Command {
    private Television television;

    public TurnOffCommand(Television television) {
        this.television = television;
    }

    public void execute() {
        television.TurnOff();
    }
}

public class RemoteControl {
    private Command? onCommand;
    private Command? offCommand;

    public void SetCommand(Command onCommand, Command offCommand) {
        this.onCommand = onCommand;
        this.offCommand = offCommand;
    }

    public void PressOnButton() {
        if (onCommand != null) onCommand.execute();
    }

    public void PressOffButton() {
        if (offCommand != null) offCommand.execute();
    }
}