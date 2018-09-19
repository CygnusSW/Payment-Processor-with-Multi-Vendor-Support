using GenericPaymentModule.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericPaymentModule.Test
{
    [TestFixture]
    public class PaymentProcessorSpec
    {
        private PaymentProcessor _paymentProcessor = new PaymentProcessor();
        private StripePaymentRequest _defaultPayment;
        [SetUp]
        public void SetUp()
        {
            _defaultPayment = new StripePaymentRequest();
        }

        [TestCase]
        public void MakePayment_Returns_Payment_Response()
        {
            PaymentResponse res = _paymentProcessor.MakePayment(_defaultPayment);
            Assert.IsInstanceOf<PaymentResponse>(res, "Making a payment does not return an instance of the response object.");
        }

        [TestCase]
        public void MakePayment_Returns_Unsuccessful_If_Amount_Is_Zero()
        {
            _defaultPayment.Amount = 0.00m;
            PaymentResponse res = _paymentProcessor.MakePayment(_defaultPayment);
            Assert.AreEqual(false, res.Successful, "Expected response to fail if payment amount was 0.00");
            Assert.AreEqual("Amount cannot be 0", res.FailureMessage);
        }

    }
}
