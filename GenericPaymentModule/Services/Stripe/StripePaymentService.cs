using GenericPaymentModule.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericPaymentModule.Services
{
    class StripePaymentService //: IPaymntService
    {
        public Task<PaymentResponse> MakePayment(StripePaymentRequest payment)
        {
            throw new NotImplementedException();
        }
    }
}
