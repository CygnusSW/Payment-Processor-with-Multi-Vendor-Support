using GenericPaymentModule.MockedVendors;
using GenericPaymentModule.Models;
using GenericPaymentModule.Models.Payments.Stripe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericPaymentModule.Services
{
    public class StripePaymentService //: IPaymntService
    {
        private readonly MockStripeSystem _stripeSystem;
        public StripePaymentService(MockStripeSystem stripeSystem)
        {
            _stripeSystem = stripeSystem;
        }

        public async Task<StripePaymentResponse> MakePayment(StripePaymentRequest payment)
        {
            var res = await _stripeSystem.CreateCharge(payment);
            return res;
        }
    }
}
