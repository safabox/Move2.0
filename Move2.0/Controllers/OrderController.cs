using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Move2._0.DAL;
using Move2._0.Models.ShoppingCart;
using Move2._0.ViewModel.ShoppingCart;
using Move2._0.Dto;
using RestSharp;
using Newtonsoft.Json;
using Microsoft.AspNet.Identity;

namespace Move2._0.Controllers
{
    public class OrderController : Controller
    {

        private ApplicationDbContext _context;

        public OrderController()
        {
            _context = ApplicationDbContext.Create();
        }

        protected override void Dispose(bool disposing)

        {
            _context.Dispose();

        }

        // GET: Order
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult CheckOut()
        {

            var userId = this.User.Identity.GetUserId();
            var client = _context.Client.SingleOrDefault(u => u.ApplicationUserId == userId);
            var checkOutViewModel = new CheckOutViewModel() { Email = this.User.Identity.GetUserName() };
            checkOutViewModel.Client = new ClientViewModel()
            {
                DNI = client.DNI,
                LastName = client.LastName,
                Name = client.Name
            };
            return View("CheckOut", checkOutViewModel);

        }




        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult ProcessOrder(CheckOutViewModel checkOutOrderVm)
        {
            if (!ModelState.IsValid)
            {
                var checkOutViewModel = new CheckOutViewModel();
                return View("CheckOut", checkOutViewModel);
            }
            else
            {

                var paymentDto = createPaymentDto(100, 1, checkOutOrderVm);

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
                    dynamic paymentResponse = JsonConvert.DeserializeObject(response.Content);
                    

                    Payment payment = createPayment(checkOutOrderVm.Client, Convert.ToInt32(paymentResponse.id.Value));
                    Order order = createOrder(checkOutOrderVm.Client,payment);
                    ConfirmacionViewModel confirmacionViewModel = new ConfirmacionViewModel()
                    {
                        Installments = 1,
                        PaymentMethodId = checkOutOrderVm.PaymentMethodId,
                        TransactionAmount = 100,
                        
                    };

                    if (paymentResponse.status.Value == "approved")
                    {
                        payment.PaymentStatusId = PaymentStatus.APPROVED;
                        order.OrderStatusId = OrderStatus.APPROVED;
                        order.approvalDate = DateTime.Now;
                        confirmacionViewModel.PaymentStatus = "Aprobado";
                        confirmacionViewModel.PaymentStatusId = PaymentStatus.APPROVED;
                        confirmacionViewModel.PaymentStatusDescription = "El pago ha sido aprobado";
                    }
                    else if (paymentResponse.status.Value == "in_process") {
                        payment.PaymentStatusId = PaymentStatus.PENDING;
                        order.OrderStatusId = OrderStatus.PENDING;
                        confirmacionViewModel.PaymentStatus = "Pendiente";
                        confirmacionViewModel.PaymentStatusId = PaymentStatus.PENDING;
                        confirmacionViewModel.PaymentStatusDescription = "El pago esta siendo procesado";

                    }
                    else{
                        payment.PaymentStatusId = PaymentStatus.REJECTED;
                        order.OrderStatusId = OrderStatus.REJECTED;
                        confirmacionViewModel.PaymentStatus = "Rechazado";
                        confirmacionViewModel.PaymentStatusId = PaymentStatus.REJECTED;
                        confirmacionViewModel.PaymentStatusDescription = "El pago ha sido rechazado";
                    }



                    
                    
                    return View("Confirmacion", confirmacionViewModel);

                }
                else
                {

                    var checkOutViewModel = new CheckOutViewModel();

                    return View("CheckOut", checkOutViewModel);

                }


            }
        }

        private Order createOrder(ClientViewModel client, Payment payment)
        {

            var cliente = _context.Client.SingleOrDefault(c => c.DNI == client.DNI);
            
            var order = new Order();
            order.CreatedDate = DateTime.Now;
            order.ClientId = cliente.Id;
            order.ApplicationUserId = cliente.ApplicationUserId;
            order.OrderStatusId = OrderStatus.SUBMIT;
            order.PaymentId = payment.Id;
            order =_context.Order.Add(order);
            _context.SaveChanges();
            return order;


        }

        private Payment createPayment(ClientViewModel client, int mercadoPagoId)
        {
            var paymentDb = new Payment();
            paymentDb.DateCreated = DateTime.Now;
            paymentDb.LastUpdatedTime = DateTime.Now;
            paymentDb.PaymentStatusId = PaymentStatus.PENDING;
            paymentDb.MercadoPagoId = mercadoPagoId;
            paymentDb = _context.Payment.Add(paymentDb);
            _context.SaveChanges();
            return paymentDb;
        }



        private PaymentDto createPaymentDto(int transactionAmount, int installments, CheckOutViewModel order)
        {
            var paymentDto = new PaymentDto()
            {
                transaction_amount = transactionAmount,
                token = order.Token,
                payment_method_id = order.PaymentMethodId,
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