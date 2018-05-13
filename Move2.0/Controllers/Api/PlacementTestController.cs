using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Move2._0.DAL;
using Move2._0.Models.PlacementTest;

namespace Move2._0.Controllers.Api
{
    public class PlacementTestController : ApiController
    {
        private ApplicationDbContext _context = null;

        public PlacementTestController()
        {
            _context = ApplicationDbContext.Create();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpGet]
        [Route("api/preguntasTest")]
        public IHttpActionResult GetAllPreguntasTest()
        {
            var preguntas = _context.PreguntasTest.OrderBy(c => c.Id).ToList();
            if (preguntas == null)
            {
                return NotFound();
            }
            return Ok(preguntas);
        }

        [HttpGet]
        [Route("api/preguntasTest/{NivelTestId}")]
        public IHttpActionResult GetPreguntasTest(int NivelTestId)
        {
            var preguntas = _context.PreguntasTest.Where(c => c.NivelTestId == NivelTestId).OrderBy(c => c.Id).ToList();
            if (preguntas == null)
            {
                return NotFound();
            }
            return Ok(preguntas);
        }

        [HttpGet]
        [Route("api/respuestasTest")]
        public IHttpActionResult GetAllRespuestasTest()
        {
            var respuestas = _context.RespuestasTest.OrderBy(c => c.Id).ToList();
            if (respuestas == null)
            {
                return NotFound();
            }
            return Ok(respuestas);
        }

        [HttpGet]
        [Route("api/respuestasTest/{PreguntasTestId}")]
        public IHttpActionResult GetRespuestasTest(int PreguntasTestId)
        {
            var respuestas = _context.RespuestasTest.Where(c => c.PreguntasTestId == PreguntasTestId).OrderBy(c => c.Id).ToList();
            if (respuestas == null)
            {
                return NotFound();
            }
            return Ok(respuestas);
        }

        [HttpGet]
        [Route("api/nivelTest/{Id}")]
        public IHttpActionResult GetNivel(int Id)
        {
            var nivelTest = _context.NivelTest.Where(c => c.Id == Id).FirstOrDefault();
            if (nivelTest == null)
            {
                return NotFound();
            }
            return Ok(nivelTest);
        }


    }
}
