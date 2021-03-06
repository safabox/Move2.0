﻿using System;
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
using Microsoft.AspNet.Identity;

namespace Move2._0.Controllers
{
    public class PaymentController : Controller
    {
        private ApplicationDbContext _context = null;


        public PaymentController() {
            _context = ApplicationDbContext.Create();
        }

        protected override void Dispose(bool disposing)

        {
            _context.Dispose();

        }

        // GET: Payment
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult Payment() {

            var userId = this.User.Identity.GetUserId();
            var client = _context.Client.SingleOrDefault(u => u.ApplicationUserId == userId);
            var paymentViewModel = new PaymentViewModel() { Email = this.User.Identity.GetUserName()};
            paymentViewModel.Client = new ClientViewModel() {
                DNI = client.DNI,
                LastName = client.LastName,
                Name = client.Name
            };
            return View("Payment", paymentViewModel);
        }



        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult ProcessPayment(PaymentViewModel payment)
        {
            if (!ModelState.IsValid)
            {
                var paymentViewModel = new PaymentViewModel();

                return View("Payment", paymentViewModel);
            }
            else
            {

                var paymentDto = createPayment(100, 1,payment);
                
                string access_token = "TEST-7606658901206724-040414-1683b7d185a04c0476793b0298f8dd11-44741038";
                string api = "https://api.mercadopago.com/v1/payments";
                string url = api + "?access_token=" + access_token;

                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                
                request.AddJsonBody(paymentDto);
                
                IRestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    var payments = JsonConvert.DeserializeObject(response.Content);

                    return RedirectToAction("Index", "Home");

                }
                else {

                    var paymentViewModel = new PaymentViewModel();

                    return View("Payment", paymentViewModel);

                }


            }
        }



        private PaymentDto createPayment(int transactionAmount, int installments, PaymentViewModel payment)
        {
            var paymentDto = new PaymentDto()
            {
                transaction_amount = transactionAmount,
                token = payment.Token,
                payment_method_id = payment.PaymentMethodId,
                description = "Test para Move 2.0",
                installments = installments,
                payer = getPayer(this.User.Identity.GetUserName()),

            };

            return paymentDto;
        }

        private Payer getPayer(string userName)
        {
            var user = _context.Users.SingleOrDefault(u => u.UserName == userName);
            var payer = new Payer()
            {
                first_name = user.Name,
                last_name = user.LastName,
                email = user.Email,
                identification = new IdentificactionDto()
                {
                    type = "DNI",
                    number = user.DNI
                }

            };

            return payer;

        }
    }
}