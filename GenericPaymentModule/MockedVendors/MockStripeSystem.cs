using GenericPaymentModule.Models;
using GenericPaymentModule.Models.Payments.Stripe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericPaymentModule.MockedVendors
{
    public class MockStripeSystem
    {
        public async Task<StripePaymentResponse> CreateCharge(StripePaymentRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
