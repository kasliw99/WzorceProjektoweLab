namespace Bridge
{
    public class WindowsSystem : ISystemBridge
    {
        public void GetInstalledPrograms()
        {
            Console.WriteLine("Lista programów systemu Windows");
            Console.WriteLine("- Notepad");
            Console.WriteLine("- Paint");
            Console.WriteLine("- Saper");
        }
    }   
}
