using Stripe;

namespace CGenius
{
    public class PaymentService
    {
        public string CreatePayment(decimal amount, string currency, string receiptEmail)
        {
            var options = new PaymentIntentCreateOptions
            {
                Amount = (long)(amount * 100),
                Currency = currency,
                ReceiptEmail = receiptEmail,
            };

            var service = new PaymentIntentService();
            var paymentIntent = service.Create(options);

            return paymentIntent.ClientSecret;
        }
    }

}
