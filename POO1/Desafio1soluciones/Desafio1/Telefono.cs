using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Telefono
    {
        private string marca, modelo, nroTelefono;
        private int codigoOperador;

        public Telefono(string modelo, string marca) 
        {
            this.modelo = modelo;
            this.marca = marca;
        }

        public string Modelo { get { return modelo; } }
        public string Marca { get { return marca; } }
        public string NroTelefono { get { return nroTelefono; } set { nroTelefono = value; } }
        public int CodigoOperador 
        { 
            get { return codigoOperador; } 
            set 
            { 
                codigoOperador = value; 
                if(codigoOperador != 1 && codigoOperador != 2 && codigoOperador != 3)
                {
                    codigoOperador = 0;
                }
            }
        }
        public void setNroTelefono(string phone)
        {
             nroTelefono = phone;
        }
        public string getNroTelefono()
        {
            return nroTelefono;
        }

        public string llamar()
        {
            return "Realizando llamada...";
        }
        public string llamar(string contacto)
        {
            return "Llamando a " + contacto;
        }


    }
}
