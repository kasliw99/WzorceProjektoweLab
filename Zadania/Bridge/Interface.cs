namespace Bridge
{
    public abstract class Interface
    {
        protected readonly ISystemBridge SystemBridge;

        protected Interface(ISystemBridge systemBridge)
        {
            SystemBridge = systemBridge;
        }

        public abstract void DisplayMenu();
    }
}
