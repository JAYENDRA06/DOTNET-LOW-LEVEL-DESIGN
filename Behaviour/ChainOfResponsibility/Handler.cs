namespace ChainOfResponsibility;

public class Handler {
    public static void Handle() {
        Approver supervisor = new Supervisor();
        Approver manager = new Manager();
        Approver director = new Director();

        supervisor.SetNext(manager);
        manager.SetNext(director);

        supervisor.ProcessRequest(1);
        supervisor.ProcessRequest(3);
        supervisor.ProcessRequest(7);
        supervisor.ProcessRequest(12);
    }
}