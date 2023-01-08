namespace BarotraumaCharacterEditor.API.Models
{
    public class Job
    {
        public readonly static (string name, string qualifier) Assistant = ("Assistant", "assistant");
        public readonly static (string name, string qualifier) Captain = ("Captain", "captain");
        public readonly static (string name, string qualifier) Engineer = ("Engineer", "engineer");
        public readonly static (string name, string qualifier) Mechanic = ("Mechanic", "mechanic");
        public readonly static (string name, string qualifier) Medic = ("Medical Doctor", "medicaldoctor");
        public readonly static (string name, string qualifier) SecurityOfficer = ("Security Officer", "securityofficer");
    }
}
