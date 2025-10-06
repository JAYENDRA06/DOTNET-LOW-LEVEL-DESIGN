namespace Command;

public class Handler {
    public static void Handle() {
        Television tv = new Television();
        RemoteControl remote = new RemoteControl();

        Command turnOn = new TurnOnCommand(tv);
        Command turnOff = new TurnOffCommand(tv);

        remote.SetCommand(turnOn, turnOff);
        remote.PressOnButton();
        remote.PressOffButton();
    }
}