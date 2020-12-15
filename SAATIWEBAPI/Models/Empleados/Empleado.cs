using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SAATIWEBAPI.Models
{
    public class EmpleadoIn
    {

        public string noempleado { get; set; }

        public string cedis { get; set; }

    }

    public class EmpleadoOut {

        public int NoEmpleado { get; set; }

        public string Nombre { get; set; }

        public string ApellidoP { get; set; }

        public string ApellidoM { get; set; }

        public string Ruta { get; set; }

        public string Cedis { get; set; }
       
    }


}