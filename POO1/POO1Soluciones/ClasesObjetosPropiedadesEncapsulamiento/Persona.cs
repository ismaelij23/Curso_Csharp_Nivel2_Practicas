using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObjetosPropiedadesEncapsulamiento
{
    internal class Persona
    {
        private string nombre, apellido; 
        private int edad;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public string Nombre { get { return nombre; } }
        public string Apellido { get { return apellido; } }
        public int Edad 
        {
            get { return edad; }
            set { edad = value ;} 
        }

        public string saludar()
        {
            return "Hola, soy " + nombre;
        }
        public string saludar(string personaje)
        {
            return "Hola " + personaje + " ¿Cómo estas? " + " yo soy " + nombre;
        }
    }
}
