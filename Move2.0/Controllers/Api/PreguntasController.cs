using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Move2._0.DAL;
using Move2._0.Models;

namespace Move2._0.Controllers.Api
{
    public class PreguntasController : ApiController
    {

        private ApplicationDbContext _context = null;

        public PreguntasController() {
            _context = ApplicationDbContext.Create();
        }
        protected override void Dispose(bool disposing)

        {
            _context.Dispose();

        }

        [HttpGet]
        public IEnumerable<Pregunta> GetPreguntas() {
            var preguntas = _context.Pregunta.ToList();
            return preguntas;

        }
        [HttpGet]
        public Pregunta GetPregunta(int Id) {
            var pregunta = _context.Pregunta.SingleOrDefault(c => c.Id == Id);
            return pregunta;
        }


        [HttpGet]
        [Route("api/preguntas/{Id}/respuestas")]
        public IEnumerable<Respuesta> GetRespuestas(int Id) {
            var respuestas = _context.Respuesta.Where(c => c.PreguntaId == Id).ToList();
            return respuestas;
        }

    }
}
