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
            StripePaymentResponse res = GenerateResponse(request);
            await Task.Delay(3000);//Simulate network and processing latency
            return res;
        }

        private StripePaymentResponse GenerateResponse(StripePaymentRequest request)
        {
            string stat = GetStatusFromSource(request.Source);

            //Don't do a string compare in this instance for a live system; This is a mock within a prototype, or I'd spend more time on it.
            bool success = stat == "Success"; 

            StripePaymentResponse res = new StripePaymentResponse()
            {
                amount = request.Amount,
                amount_refunded = 0,
                application = Guid.NewGuid().ToString(),
                application_fee = "0",
                balance_transaction = Guid.NewGuid().ToString(),
                captured = request.Capture,
                created = DateTime.UtcNow,
                currency = request.Currency,
                customer = request.Customer.ToString(),
                description = request.Description,
                destination = string.Empty,
                dispute = string.Empty,
                failure_code = "0", //Would be populated in live api
                failure_message =  success ? string.Empty : stat,
                id = Guid.NewGuid().ToString(),
                invoice = string.Empty,
                livemode = true, //Would be configured in this project on a production instance
                Object = "charge",
                on_behalf_of = string.Empty,
                order = string.Empty,
                paid = request.Capture,
                receipt_email = request.receipt_email,
                receipt_number = Guid.NewGuid().ToString(),
                refunded = false,
                review = string.Empty,
                source_transfer = string.Empty,
                transfer = string.Empty,
                statement_descriptor = string.Empty,
                status = success ? "Success" : stat,
                transfer_group = string.Empty
            };
            return res;
        }

        private string GetStatusFromSource(string source)
        {
            string status = "Invalid Source";
            switch (source)
            {
                case "tok_success":
                    status = "Success";
                    break;
                case "tok_balance":
                    status = "Insufficient Balance";
                    break;
                case "tok_expired":
                    status = "Card Expired";
                    break;
                case "tok_csc":
                    status = "Incorrect Security Code";
                    break;
                case "tok_zip":
                    status = "Incorrect Zip Code";
                    break;
            }
            return status;
        }

    }
}
