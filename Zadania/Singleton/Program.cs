class Program
{
    static void Main(string[] args)
    {
        Vault firstAttempt = Vault.GetInstance();
        Console.WriteLine("Pierwszy klucz dostępu: " + firstAttempt.GetAccessKey());

        Vault secondAttempt = Vault.GetInstance();
        Console.WriteLine("Drugi klucz dostępu: " + secondAttempt.GetAccessKey());
    }
}

