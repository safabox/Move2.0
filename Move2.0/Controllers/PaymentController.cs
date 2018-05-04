using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Move2._0.DAL;
using Move2._0.Models.ShoppingCart;
using Move2._0.Models.Move;
using Move2._0.ViewModel.ShoppingCart;
using Move2._0.Dto;
using RestSharp;
using Newtonsoft.Json;

namespace Move2._0.Controllers
{
    public class PaymentController : Controller
    {
        private ApplicationDbContext _context = null;
        
        // GET: Payment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Payment() {

            var paymentViewModel = new PaymentViewModel();
            return View("Payment",paymentViewModel);
        }



        [HttpPost]
        
        public ActionResult ProcessPayment(PaymentViewModel payment)
        {
            if (!ModelState.IsValid)
            {
                var paymentViewModel = new PaymentViewModel();

                return View("Payment", paymentViewModel);
            }
            else
            {
                var paymentDto = new PaymentDto() {
                    transaction_amount = 100,
                    token = payment.Token,
                    payment_method_id = payment.PaymentMethodId,
                    description = "Test para Move 2.0",
                    installments = 1,
                    payer = new Payer() { email = payment.Email },

                };

                string access_token = "TEST-7606658901206724-040414-1683b7d185a04c0476793b0298f8dd11-44741038";
                string api = "https://api.mercadopago.com/v1/payments";
                string url = api + "?access_token=" + access_token;

                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                string jsonData = JsonConvert.SerializeObject(paymentDto);
                request.AddJsonBody(paymentDto);
               

                IRestResponse response = client.Execute(request);
                dynamic results = JsonConvert.DeserializeObject(response.Content);
                var payments = results.results;
                foreach (var a in payments)
                {
                    Console.WriteLine(a.id);
                }



                return RedirectToAction("Index", "Home");
            }
        }


    }
}