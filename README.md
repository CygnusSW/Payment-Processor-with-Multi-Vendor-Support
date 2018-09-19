# Vendor Abstraction Problem #
## Problem Statement ##
You are interfacing with a vendor, and want to be able to add an additional vendor at run-time. In this example, we use a payment processor as an example.
## Set-Up ##
For the initial set-up, we're going to create a basic application.
To set up the problem, we'll need to implement the following:
1. A payment class that models the payment itself
2. A payment processor class that is responsible for accepting a payment from consuming code (api, console application, etc.), sending to the payment-processing vendor, and returning the results;
3. A payment service that is used by payment processor objects to send payment requests to vendors and return the responses
4. A fake "StripeVendor" class that will serve as a testing dummy for our payment requests. 

For the contract between the payment service and the fake StripeVendor, we'll be using Stripe's API docs for this initial interface (https://stripe.com/docs/api#intro).

No logging is included in this example, nor a consuming project.



## Approach ##
1. Create a generic payment object that has the base payment information (every payment has an "amount", for example)
2. 
