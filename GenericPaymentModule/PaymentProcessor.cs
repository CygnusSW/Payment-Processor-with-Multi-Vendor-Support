using GenericPaymentModule.Models;
using GenericPaymentModule.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericPaymentModule
{
    public class PaymentProcessor
    {
        private readonly StripePaymentService _stripeService;

        public PaymentProcessor(StripePaymentService stripeService) 
        {
            _stripeService = stripeService;
        }

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
