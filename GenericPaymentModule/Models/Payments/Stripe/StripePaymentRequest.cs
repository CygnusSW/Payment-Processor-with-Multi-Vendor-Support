using GenericPaymentModule.Models.Payments.Stripe;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericPaymentModule.Models
{
    /// <summary>
    /// See https://stripe.com/docs/api/dotnet#create_charge for contract definition
    /// </summary>
    public class StripePaymentRequest 
    {
        public decimal Amount;
        public string Currency;
        public decimal ApplicationFee;
        public bool Capture;
        public Guid Customer;
        //public Destination Ignoring this one for time's sake.
        public StripeMetaData MetaData;
        public Guid OnBehalfOf;
        public string receipt_email;
        //public ShippingInfo Shipping; Ignoring for time's sake
        public string Source;
        public string StatementDescription;
        public string Description;
        public string TransferGroup;
    }
}
