namespace ShopDecorator
{
    public class LoyaltyPointsDecorator : PaymentDecorator
    {
        public LoyaltyPointsDecorator(IPayment payment) : base(payment) { }

        public override void Pay()
        {
            base.Pay();
            AddLoyaltyPoints();
        }

        private void AddLoyaltyPoints()
        {
            Console.WriteLine("Dodano punkty lojalnościowe");
        }
    }
}