namespace Bridge
{
    public class CommandLineInterface : Interface
    {
        public CommandLineInterface(ISystemBridge systemBridge) : base(systemBridge) { }

        public override void DisplayMenu()
        {
            Console.WriteLine("Interfejs wiersza poleceń:");
            SystemBridge.GetInstalledPrograms();
        }
    }
}
