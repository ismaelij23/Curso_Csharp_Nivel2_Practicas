using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesObjetosPropiedadesEncapsulamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro perro1 = new Perro();
            perro1.setNombre("Titan");
            perro1.setEdad(14);
            Console.WriteLine("El perro se llama " + perro1.getNombre() + " y tiene " + perro1.getEdad() + " años!");

            Persona persona1 = new Persona("Ismael", "Juaristi");
            persona1.Edad = 26;
            Console.WriteLine("El nombre de la persona es " + persona1.Nombre + " "+ persona1.Apellido +" y tiene " + persona1.Edad + " años");
            Console.WriteLine(persona1.saludar());
            Console.WriteLine(persona1.saludar("Antonio"));

            Botella botella1 = new Botella("Verde", "Plástico");
            Console.WriteLine("La capacidad de la botella es de " + botella1.Capacidad);
            Console.WriteLine("La cantidad actual es de " + botella1.CantidadActual);
            botella1.recargar();
            Console.WriteLine("Luego de recargar, la cantidad actual es de " + botella1.CantidadActual);

            Console.ReadKey();
        }
    }
}
