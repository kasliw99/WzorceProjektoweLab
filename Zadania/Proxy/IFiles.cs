namespace Proxy
{
    public interface IFiles
    {
        void AccessFile();
    }

    public class PublicFile : IFiles
    {
        public void AccessFile()
        {
            Console.WriteLine("dostęp do pliku publicznego");
        }
    }

    public class ProtectedFile : IFiles
    {
        public void AccessFile()
        {
            Console.WriteLine("dostęp do pliku zastrzeżonego");
        }
    }
}
