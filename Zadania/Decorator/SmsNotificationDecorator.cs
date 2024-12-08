namespace ShopDecorator
{
    public class SmsNotificationDecorator : PaymentDecorator
    {
        public SmsNotificationDecorator(IPayment payment) : base(payment) { }

        public override void Pay()
        {
            base.Pay();
            SendSmsNotification();
        }

        private void SendSmsNotification()
        {
            Console.WriteLine("przesłano SMS potwierdzający płatność");
        }
    }
}