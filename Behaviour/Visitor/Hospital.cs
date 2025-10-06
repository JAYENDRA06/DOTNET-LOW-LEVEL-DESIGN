namespace Visitor;

interface Patient {
    void Accept(Visitor visitor);
}
class ChildPatient: Patient {
    public void Accept(Visitor visitor) {
        visitor.Visit(this);
    }
}

class AdultPatient: Patient {
    public void Accept(Visitor visitor) {
        visitor.Visit(this);
    }
}

interface Visitor {
    void Visit(ChildPatient child);
    void Visit(AdultPatient adult);
}

class Doctor : Visitor {
    public void Visit(ChildPatient child) {
        Console.WriteLine("Doctor is treating a child patient.");
    }

    public void Visit(AdultPatient adult) {
        Console.WriteLine("Doctor is treating an adult patient.");
    }
}

class Nurse : Visitor {
    public void Visit(ChildPatient child) {
        Console.WriteLine("Nurse is assisting a child patient.");
    }

    public void Visit(AdultPatient adult) {
        Console.WriteLine("Nurse is assisting an adult patient.");
    }
}