using SAATIWEBAPI.Models;
using SAATIWEBAPI.Models.Mensajes;
using SAATIWEBAPI.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SAATIWEBAPI.Controllers
{
    [RoutePrefix("api/registro")]
    public class RegistrosController : ApiController
    {

        private static readonly string CLASS_NAME = typeof(RegistrosController).FullName;

        [HttpPost]
        [Route("ObtenerEmpleado")]

        public IHttpActionResult GetObtenerEmpleado(EmpleadoIn empleado) {

            var result = new RegistrosNegocio().ObtenerEmpleado(empleado);

      
            return Json(result);
            
        }

    }
}