namespace CodeSmells
{
    internal class RefusedBequest
    {
        public interface IEmployee
        {
            void Work() { /**/ }
            void AttendMeeting() { /**/ }
        }
        public class Employee : IEmployee
        {
            public string Name { get; set; }
            public string Position { get; set; }
            public void Work() { /* Implementacja */ }
            public void AttendMeeting() { /* Implementacja */ }
        }

        public class Manager : Employee
        {
            public void ManageTeam() { /* Implementacja */ }
        }
    }
}
