namespace ShopDecorator
{
    public class RedirectToHomeDecorator : PaymentDecorator
    {
        public RedirectToHomeDecorator(IPayment payment) : base(payment) { }

        public override void Pay()
        {
            base.Pay();
            RedirectToHomePage();
        }

        private void RedirectToHomePage()
        {
            Console.WriteLine("Przekierowano na stronę główną");
        }
    }
}