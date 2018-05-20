
using System.Linq;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;
using Move2._0.DAL;
using Move2._0.Models.PlacementTest;
using Move2._0.ViewModel.Test;
using Microsoft.AspNet.Identity;
using Move2._0.Dto.Test;

namespace Move2._0.Controllers
{
    public class TestController : Controller
    {
        private ApplicationDbContext _context = null;

        public TestController()
        {
            _context = ApplicationDbContext.Create();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();

        }

        public ActionResult Index()
        {

            var estaAutenticado = this.User.Identity.IsAuthenticated;
            var testIndexViewModel = new TestIndexViewModel()
            {
                Email = "",
                Nombre = "",
                NivelTestId = 0
            };

            if (estaAutenticado)
            {
                var userId = this.User.Identity.GetUserId();
                var client = _context.Client.SingleOrDefault(u => u.ApplicationUserId == userId);

                testIndexViewModel.Email = this.User.Identity.GetUserName();
                testIndexViewModel.Nombre = client.Name + ' ' + client.LastName;

            }
            
            return View(testIndexViewModel);
        }

        [HttpPost]
        public ActionResult TestNivel(TestIndexViewModel testIndexViewModelVm)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }

            return View("TestNivel", ObtenerDatos(testIndexViewModelVm));
            
        }

        [HttpPost]
        public ActionResult NextTestNivel(TestNivelViewModel testNivelViewModelVm)
        {
            var nivel = testNivelViewModelVm.NivelTestId + 1;

            if (!ModelState.IsValid)
            {
                return View("Index");
            }

            if (VerificarTestNivel(testNivelViewModelVm))
            {
                ModelState.Clear();

                return View("TestNivel", ObtenerDatos(testNivelViewModelVm, nivel));
            }
            else
            {
                var descripcionNivel = "";

                switch (nivel)
                {
                    case 1:
                        descripcionNivel = "Su Nivel es Inicial";
                        break;
                    case 2:
                        descripcionNivel = "Su Nivel es Elemental";
                        break;
                    case 3:
                        descripcionNivel = "Su Nivel es Pre-Intermedio";
                        break;
                    case 4:
                        descripcionNivel = "Su Nivel es Intermedio";
                        break;
                    case 5:
                        descripcionNivel = "Su Nivel es Intermedio Alto";
                        break;
                    case 6:
                        descripcionNivel = "Su Nivel es Avanzado";
                        break;
                }

                var email = testNivelViewModelVm.Email;
                var nombre = testNivelViewModelVm.Nombre;
                var nivelFinal = nivel - 1;

                ModelState.Clear();

                var testFinViewModel = new TestFinViewModel()
                {
                    Email = email,
                    Nombre = nombre,
                    NivelTestId = nivelFinal,
                    DescripcionNivel = descripcionNivel
                };

                TestFin(testFinViewModel);

                return View("TestFin", testFinViewModel);
            }

        }

        private void TestFin(TestFinViewModel testFinViewModelVm)
        {
            var placementeTest = new PlacementTest
            {
                Mail = testFinViewModelVm.Email,
                Nombre = testFinViewModelVm.Nombre,
                Nivel = testFinViewModelVm.NivelTestId
            };
            placementeTest = _context.PlacementTest.Add(placementeTest);
            _context.SaveChanges();

            SmtpClient client = new SmtpClient("mail.safabox.com");
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("noreply@safabox.com", "noreply123!");

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("noreply@safabox.com");
            mailMessage.To.Add("speralta83@gmail.com");
            mailMessage.Body = "Nombre: " + testFinViewModelVm.Nombre + "\r\nMail: " + testFinViewModelVm.Email + "\r\nNivel: " + testFinViewModelVm.DescripcionNivel;
            mailMessage.Subject = "Contacto MoveLanguage - PLACEMENT TEST";
            client.Send(mailMessage);
        }
        
        private TestNivelViewModel ObtenerDatos (TestIndexViewModel testIndexViewModelVm)
        {
            var preguntas = (from p in _context.PreguntasTest
                             where p.NivelTestId == testIndexViewModelVm.NivelTestId + 1 
                             select new PreguntasTestDto
                             {
                                 Id = p.Id,
                                 Pregunta = p.Pregunta,
                                 NivelTestId = p.NivelTestId,
                                 IdRespuesta = 0
                             }
                ).ToList();
            var respuestas = (from r in _context.RespuestasTest
                              join p in _context.PreguntasTest
                              on r.PreguntasTestId equals p.Id
                              where p.NivelTestId == testIndexViewModelVm.NivelTestId + 1
                              select new RespuestasTestDto
                              {
                                  Id = r.Id,
                                  Respuesta = r.Respuesta,
                                  Correcta = r.Correcta,
                                  PreguntasTestId = r.PreguntasTestId,
                                  NivelTestId = p.NivelTestId
                              }).ToList();

            var testNivelViewModel = new TestNivelViewModel()
            {
                Email = testIndexViewModelVm.Email,
                Nombre = testIndexViewModelVm.Nombre,
                PreguntasTestDto = preguntas,
                RespuestasTestDto = respuestas,
                NivelTestId = testIndexViewModelVm.NivelTestId +1
            };

            ModelState.Clear();

            return testNivelViewModel;
        }

        private TestNivelViewModel ObtenerDatos(TestNivelViewModel testNivelViewModelVm, int proximoNivel)
        {
            var preguntas = (from p in _context.PreguntasTest
                             where p.NivelTestId == proximoNivel
                             select new PreguntasTestDto
                             {
                                 Id = p.Id,
                                 Pregunta = p.Pregunta,
                                 NivelTestId = p.NivelTestId,
                                 IdRespuesta = 0
                             }
                ).ToList();
            var respuestas = (from r in _context.RespuestasTest
                              join p in _context.PreguntasTest
                              on r.PreguntasTestId equals p.Id
                              where p.NivelTestId == proximoNivel
                              select new RespuestasTestDto
                              {
                                  Id = r.Id,
                                  Respuesta = r.Respuesta,
                                  Correcta = r.Correcta,
                                  PreguntasTestId = r.PreguntasTestId,
                                  NivelTestId = p.NivelTestId
                              }).ToList();

            var testNivelViewModel = new TestNivelViewModel()
            {
                Email = testNivelViewModelVm.Email,
                Nombre = testNivelViewModelVm.Nombre,
                PreguntasTestDto = preguntas,
                RespuestasTestDto = respuestas,
                NivelTestId = proximoNivel
            };

            ModelState.Clear();

            return testNivelViewModel;
        }

        private bool VerificarTestNivel(TestNivelViewModel testNivelViewModelVm)
        {

            var contadorError = 0;
            var cantidadRespustaIncorrectasNivel = _context.NivelTest.Where(n => n.Id == testNivelViewModelVm.NivelTestId);

            var listaRespuestaCliente = testNivelViewModelVm.RespustaSeleccionada;
            var listaRespuestasCorrectas = testNivelViewModelVm.RespuestasTestDto.Where(x => x.Correcta == true && x.NivelTestId == testNivelViewModelVm.NivelTestId).ToList();
                
            for (var i = 0; i < listaRespuestaCliente.Count; i++)
            {
                if(listaRespuestaCliente[i].ToString() != listaRespuestasCorrectas[i].Id.ToString())
                {
                    contadorError++;
                }
            }

            if (contadorError > cantidadRespustaIncorrectasNivel.FirstOrDefault().CantidadRespuestasIncorrectas)
            {
                return false;
            }
            else
            {
                return true;
            }            
        }

    }
}