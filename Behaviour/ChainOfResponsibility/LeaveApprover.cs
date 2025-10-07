namespace ChainOfResponsibility;

// THEORY: a request is passed along a chain of handlers. Each handler decides either to process the request or to pass it to the next handler in the chain.

public abstract class Approver {
    protected Approver? nextApprover;

    public void SetNext(Approver approver) {
        nextApprover = approver;
    }

    public abstract void ProcessRequest(int days);
}

public class Supervisor : Approver {
    public override void ProcessRequest(int days) {
        if (days <= 2) {
            Console.WriteLine($"Supervisor approved leave for {days} days.");
        } else if (nextApprover != null) {
            nextApprover.ProcessRequest(days);
        }
    }
}
public class Manager : Approver {
    public override void ProcessRequest(int days) {
        if (days <= 5) {
            Console.WriteLine($"Manager approved leave for {days} days.");
        } else if (nextApprover != null) {
            nextApprover.ProcessRequest(days);
        }
    }
}
public class Director : Approver {
    public override void ProcessRequest(int days) {
        if (days <= 10) {
            Console.WriteLine($"Director approved leave for {days} days.");
        } else if (nextApprover != null) {
            nextApprover.ProcessRequest(days);
        } else {
            Console.WriteLine("Leave request denied.");
        }
    }
}