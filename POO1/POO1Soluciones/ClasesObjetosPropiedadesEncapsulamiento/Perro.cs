using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObjetosPropiedadesEncapsulamiento
{
    internal class Perro
    {
        private string nombre, color, origen;
        private int edad;

        public void setNombre(string name)
        {
            nombre = name;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setColor(string col)
        {
            color = col;
        }
        public string getColor()
        {
            return color;
        }
        public void setOrigen(string origin)
        {
            origen = origin;
        }
        public string getOrigen()
        {
            return origen;
        }
        public void setEdad(int e)
        {
            edad = e;
        }
        public int getEdad()
        {
            return edad;
        }

    }
}
