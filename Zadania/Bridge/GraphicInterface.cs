namespace Bridge
{
    public class GraphicInterface : Interface
    {
        public GraphicInterface(ISystemBridge systemBridge) : base(systemBridge) { }

        public override void DisplayMenu()
        {
            Console.WriteLine("Graficzny interfejs użytkownika:");
            SystemBridge.GetInstalledPrograms();
        }
    }
}
