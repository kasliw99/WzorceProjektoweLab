using System;

namespace Proxy
{
    public class FileProxy : IFiles
    {
        private ProtectedFile _protectedFile;
        private readonly string _password = "1234";

        public void AccessFile()
        {
            _protectedFile = new ProtectedFile();
            Console.Write("Podaj hasło: ");
            string inputPassword = Console.ReadLine();

            if (inputPassword == _password)
            {
                _protectedFile.AccessFile();
            }
            else
            {
                Console.WriteLine("Nieprawidłowe hasło");
            }
        }
    }
}
