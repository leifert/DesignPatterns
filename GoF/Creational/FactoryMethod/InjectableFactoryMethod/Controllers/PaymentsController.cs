using InjectableFactoryMethod.DTO;
using InjectableFactoryMethod.Enums;
using InjectableFactoryMethod.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace InjectableFactoryMethod.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PaymentsController : Controller
    {
        private readonly Func<PaymentMethod, IPaymentService?> _paymentFactory;

        public PaymentsController(Func<PaymentMethod, IPaymentService?> paymentFactory)
        {
            _paymentFactory = paymentFactory;
        }

        [HttpPost("makePayment")]
        public IActionResult PayAsync([FromBody] PaymentRequestDto request)
        {
            IPaymentService? payment = _paymentFactory(request.PaymentMethod);

            if (payment is null)
            {
                return BadRequest("Unsupported payment method.");
            }
            string result = payment.Pay(request.Amount);

            return Ok(result);
        }
    }
}
