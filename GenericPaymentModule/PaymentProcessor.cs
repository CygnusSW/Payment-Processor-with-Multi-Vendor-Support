using GenericPaymentModule.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericPaymentModule
{
    public class PaymentProcessor
    {
        public PaymentResponse MakePayment(StripePaymentRequest payment)
        {
            var res = new PaymentResponse();

            if (payment.Amount <= 0.00m)
            {
                res.FailureMessage = "Amount cannot be 0";
            }

            


            return res;
        }
    }
}
