namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            ISystemBridge windowsSystem = new WindowsSystem();
            Interface windowsGui = new GraphicInterface(windowsSystem);

            ISystemBridge linuxSystem = new LinuxSystem();
            Interface linuxCli = new CommandLineInterface(linuxSystem);

            Console.WriteLine("Windows GUI");
            windowsGui.DisplayMenu();

            Console.WriteLine("Linux CLI");
            linuxCli.DisplayMenu();

            Console.WriteLine("Linux GUI");
            Interface linuxGui = new GraphicInterface(linuxSystem);
            linuxGui.DisplayMenu();

            Console.ReadKey();
        }
    }
}
