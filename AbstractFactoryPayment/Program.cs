// See https://aka.ms/new-console-template for more information


IPaymentGatewayFactory paymementGatewayFactory = new PayPalGatewayFactory();
PaymentService paymentService = new PaymentService(paymementGatewayFactory);
paymentService.ProcessPayment(50);

IPaymentGatewayFactory stripeGatewayFactory = new StripeGatewayFactory();
PaymentService paymentService1 = new PaymentService(stripeGatewayFactory);
paymentService1.ProcessPayment(25);