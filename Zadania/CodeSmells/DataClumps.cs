namespace CodeSmells
{
    internal class DataClumps
    {
        //public void RegisterEvent(string eventName, DateTime eventDate, string location)
        //{
        //    Console.WriteLine($"Event: {eventName}, Date: {eventDate}, Location: {location}");
        //}
        public class EventDetails
        {
            public string EventName { get; set; }
            public DateTime EventDate { get; set; }
            public string Location { get; set; }

            // Metoda RegisterEvent korzystająca z właściwości bieżącego obiektu
            public void RegisterEvent()
            {
                Console.WriteLine($"Event: {EventName}, Date: {EventDate}, Location: {Location}");
            }
        }
    }
}
