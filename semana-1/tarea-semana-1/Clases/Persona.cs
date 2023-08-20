using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        public string nombres;
        public int edad;
        public string codigo;
        public string email;
        public Persona(string nombres, int edad)
        {
            this.nombres = nombres.Trim();
            this.edad = edad;
            generarCodigo();
            generarEmail();
        }
        private void generarCodigo()
        {
            Random r = new Random();
            int codigoInicial = r.Next(1000, 9999);
            this.codigo = "N" + codigoInicial.ToString() + "P";
        }
        private void generarEmail()
        {

            string[] palabras = this.nombres.Split(' ');
            char[] primerasLetras = new char[palabras.Length];
            for (int i = 0; i < palabras.Length; i++)
            {
                char letra = palabras[i][0];
                primerasLetras[i] = letra;
            }
            this.email = string.Join("", primerasLetras) + "@upn.pe";
            this.email = this.email.ToLower();
        }
        public void mostrarPersona()
        {
            Console.WriteLine("\n");
            Console.WriteLine(this.nombres);
            Console.WriteLine(this.edad);
            Console.WriteLine(this.codigo);
            Console.WriteLine(this.email);
        }
    }
}
