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
        public int[] notasMatematica = new int[3];
        public int[] notasLenguaje = new int[3];
        public int[] notasHistoria = new int[3];
        public Persona(string nombres, int edad)
        {
            this.nombres = nombres.Trim();
            this.edad = edad;
            generarCodigo();
            generarEmail();
            pedirNotas();
        }
        public void pedirNotas()
        {
            Console.WriteLine("Introduzca las notas de matemática");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Nota "+(i+1)+": ");
                int tempNota = int.Parse(Console.ReadLine());
                while (tempNota < 0 || tempNota > 20)
                {
                    Console.WriteLine("Nota fuera de los parámetros");
                    Console.Write("Nota " + (i + 1) + ": ");

                    tempNota = int.Parse(Console.ReadLine());
                }
                notasMatematica[i] = tempNota;

            }
            Console.WriteLine("Introduzca las notas de lenguaje");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Nota " + (i + 1) + ": ");
                int tempNota = int.Parse(Console.ReadLine());
                while (tempNota < 0 || tempNota > 20)
                {
                    Console.WriteLine("Nota fuera de los parámetros");
                    Console.Write("Nota " + (i + 1) + ": ");

                    tempNota = int.Parse(Console.ReadLine());
                }
                notasLenguaje[i] = tempNota;
            }
            Console.WriteLine("Introduzca las notas de historia");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Nota " + (i + 1) + ": ");
                int tempNota = int.Parse(Console.ReadLine());
                while (tempNota < 0 || tempNota > 20)
                {
                    Console.WriteLine("Nota fuera de los parámetros");
                    Console.Write("Nota " + (i + 1) + ": ");

                    tempNota = int.Parse(Console.ReadLine());
                }
                notasHistoria[i] = tempNota;
            }
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
            Console.WriteLine("\t\tNota 1\tNota 2\tNota 3");
            Console.WriteLine("Matemática:\t" + notasMatematica[0] + "\t" + notasMatematica[1] + "\t" + notasMatematica[2]);
            Console.WriteLine("Lenguaje:\t" + notasLenguaje[0] + "\t" + notasLenguaje[1] + "\t" + notasLenguaje[2]);
            Console.WriteLine("Historia:\t" + notasHistoria[0] + "\t" + notasHistoria[1] + "\t" + notasHistoria[2]);


        }
    }
}
