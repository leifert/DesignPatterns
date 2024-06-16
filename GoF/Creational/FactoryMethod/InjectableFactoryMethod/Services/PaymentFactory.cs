using InjectableFactoryMethod.Enums;
using InjectableFactoryMethod.Services.IServices;

namespace InjectableFactoryMethod.Services
{
    public static class PaymentFactory
    {
        public static IPaymentService? AddPaymentFactory(this IServiceCollection services)
        {
            // register all implementation of IPayment interface
            services.AddScoped<CreditCardPaymentService>();
            services.AddScoped<PayPalPaymentService>();
            services.AddScoped<GooglePayPaymentService>();

            //register a factory function that accepts a PaymentMethod parameter and returns the corresponding IPaymentService implementation
            services.AddTransient<Func<PaymentMethod, IPaymentService?>>(serviceProvider => key =>
            {
                switch (key)
                {
                    case PaymentMethod.CreditCard:
                        return serviceProvider.GetService<CreditCardPaymentService>();

                    case PaymentMethod.PayPal:
                        return serviceProvider.GetService<PayPalPaymentService>();

                    case PaymentMethod.GooglePay:
                        return serviceProvider.GetService<GooglePayPaymentService>();

                    default:
                        throw new NotSupportedException(
                            $"{key} is not currently supported as a payment method."
                        );
                }
            });

            return null;
        }
    }
}
