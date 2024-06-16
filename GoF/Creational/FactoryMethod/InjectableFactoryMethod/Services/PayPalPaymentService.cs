using InjectableFactoryMethod.Services.IServices;

namespace InjectableFactoryMethod.Services
{
    public class PayPalPaymentService : IPaymentService
    {
        public string Pay(double amount)
        {
            return $"Successfully paid ${amount} to merchant using PayPal.";
        }
    }
}
