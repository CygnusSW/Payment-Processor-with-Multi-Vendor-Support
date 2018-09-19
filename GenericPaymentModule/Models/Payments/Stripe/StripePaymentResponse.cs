using System;
using System.Collections.Generic;
using System.Text;

namespace GenericPaymentModule.Models.Payments.Stripe
{
    public class StripePaymentResponse
    {
        public string id;
        public string Object = "charge";
        public int amount;
        public int amount_refunded;
        public string application;
        public string application_fee;
        public string balance_transaction;
        public bool captured;
        public DateTime created;
        public decimal currency;
        public string customer;
        public string description;
        public string destination;
        public string dispute;
        public string failure_code;
        public string failure_message;
        public string invoice;
        public bool livemode;
        public string on_behalf_of;
        public string order;
        public bool paid;
        public string receipt_email;
        public string receipt_number;
        public bool refunded;
        public string review;
        public string source_transfer;
        public string statement_descriptor;
        public string status;
        public string transfer;
        public string transfer_group;
    }
}
