namespace ShopDecorator
{
    public class CardPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Zapłacono kartą");
        }
    }
}