using InjectableFactoryMethod.Services.IServices;

namespace InjectableFactoryMethod.Services
{
    public class CreditCardPaymentService : IPaymentService
    {
        public string Pay(double amount)
        {
            return $"Successfully paid ${amount} to merchant using a Credit Card.";
        }
    }
}
