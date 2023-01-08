using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono tel1 = new Telefono("g60s", "Motorola");
            tel1.CodigoOperador = 4;
            Console.WriteLine("El codigo del tel es : " + tel1.CodigoOperador);
            tel1.setNroTelefono("430464");
            string nroTel1 = tel1.getNroTelefono();
            Console.WriteLine("El número de teléfono es: " + nroTel1);
            Console.WriteLine(tel1.llamar());
            Console.WriteLine(tel1.llamar("Norman"));
            
            Console.ReadKey();
        }
    }
}
