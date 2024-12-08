namespace ShopDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz metodę płatności:");
            Console.WriteLine("1 - Płatność kartą");
            Console.WriteLine("2 - Płatność gotówką");
            Console.WriteLine("3 - Płatność BLIK");

            string choice = Console.ReadLine();
            IPayment payment;

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Płatność kartą z zastosowaniem dekoratorów");
                    payment = new CardPayment();
                    payment = new SmsNotificationDecorator(payment);
                    payment = new LoyaltyPointsDecorator(payment);
                    payment = new RedirectToHomeDecorator(payment); 
                    payment.Pay();
                    break;

                case "2":
                    Console.WriteLine("Płatność gotówką wykonana bez dekoratorów");
                    break;

                case "3":
                    Console.WriteLine("Płatność BLIK wykonana bez dekoratorów");
                    break;

                default:
                    Console.WriteLine("Nieprawidłowy wybór");
                    break;
            }

            Console.WriteLine("Done");
        }
    }
}