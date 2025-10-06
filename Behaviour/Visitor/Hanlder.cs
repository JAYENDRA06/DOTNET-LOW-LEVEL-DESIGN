namespace Visitor;

public class Handler {
    public static void Handle() {
        List<Patient> patients = new List<Patient>
        {
            new ChildPatient(),
            new AdultPatient()
        };

        Visitor doctor = new Doctor();
        Visitor nurse = new Nurse();

        foreach (var patient in patients) {
            patient.Accept(doctor);
            patient.Accept(nurse);
        }
    }
}