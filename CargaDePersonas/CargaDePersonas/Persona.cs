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

        public string Nombre { get; set; } //Propiedades de personas o cosas

        public string Apellido { get; set; } //Propiedades de personas o cosas

        public int Edad { get; set; } //Propiedades de personas o cosas

        public string NombreCompleto() //Métodos // Return: Retorna las propiedades de la
        {                                        // persona, cuando se cargan los datos en nombre / apellido / Edad     
            
            return Nombre + ", " + Apellido + ", " + Edad;

        }

        public CursadoDeMateria CursadoDeMateria { get; set; }


    }
}
