using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObjetosPropiedadesEncapsulamiento
{
    internal class Botella
    {
        private string color, material;
        private int capacidad, cantidadActual;
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }
        public Botella() { }
        
        // int Capacidad { get { return capacidad; } set { capacidad = value; } }
        public string Material { get { return material; } set { } }
        public int Capacidad { get { return capacidad; } set { } }
        public int CantidadActual { get { return cantidadActual;} set { } }

        public float recargar()
        {
            if(cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual; 
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }
        
    }
}
