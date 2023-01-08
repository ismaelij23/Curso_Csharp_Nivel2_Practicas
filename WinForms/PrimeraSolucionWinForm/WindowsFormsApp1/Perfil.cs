using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Perfil
    {
        public string Nombre { get; set; }
        public DateTime FechaNac { get; set; }
        public string Chocolate { get; set; }
        public string Genero { get; set; }
        public string ColorFav { get; set; }
        public string NumFav { get; set; }

        public string presentacion()
        {
            return "Hola " + Nombre + " bienvenido a la App\n" + "Fecha de nacimiento: " + FechaNac + "\n" + "Le gusta el chocolate: " + Chocolate + "\n" + "Género: " + Genero + "\n" + "Color Favorito: " + ColorFav + "\n" + "Número Favorito: " + NumFav;
        }
    }
}
