using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargaDePersonas
{
    public class Persona
    {
        //Get = leer
        //Set = modificar

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Edad { get; set; }

        public string NombreCompleto()
        {
            return Nombre + ", " + Apellido + ", " + Edad;
        }
    }
}
