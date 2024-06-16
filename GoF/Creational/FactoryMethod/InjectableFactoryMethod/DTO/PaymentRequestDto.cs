using InjectableFactoryMethod.Enums;

namespace InjectableFactoryMethod.DTO
{
    public class PaymentRequestDto
    {
        public double Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
