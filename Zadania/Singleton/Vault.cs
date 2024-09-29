using System;

class Vault
{
    private static Vault vault;
    private int accessKey;

    // Prywatny konstruktor, aby uniemożliwić tworzenie obiektów z zewnątrz
    private Vault()
    {
        Random random = new Random();
        accessKey = random.Next(1000, 9999);
    }

    // Statyczna metoda do uzyskania dostępu do Singletona
    public static Vault GetInstance()
    {
        if (vault == null)
        {
            vault = new Vault();
        }
        return vault;
    }

    public int GetAccessKey()
    {
        return accessKey;
    }
}
