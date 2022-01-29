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

        public Materia MateriaCursada { get; set; } //Propiedad de la persona, en este caso tambien incluye la materia
                                                    //Materia es en este caso la clase creada, donde anexamos con la clase persona, su propiedad

        public void Inscribir(Materia materia)  //Propiedad de la persona
        {
            MateriaCursada = materia;
            
        }



    }
}
