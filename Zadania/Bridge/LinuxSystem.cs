namespace Bridge
{
    internal class LinuxSystem : ISystemBridge
    {
        public void GetInstalledPrograms()
        {
            Console.WriteLine("Lista programów systemu Linux");
            Console.WriteLine("- Safari");
            Console.WriteLine("- Mac Studio");
            Console.WriteLine("- BigMac");
        }
    }
}
