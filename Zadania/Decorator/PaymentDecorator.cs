namespace ShopDecorator
{
    // Abstrakcyjny dekorator dla płatności
    public abstract class PaymentDecorator : IPayment
    {
        protected IPayment _payment;

        protected PaymentDecorator(IPayment payment)
        {
            _payment = payment;
        }

        public virtual void Pay()
        {
            _payment.Pay();
        }
    }
}