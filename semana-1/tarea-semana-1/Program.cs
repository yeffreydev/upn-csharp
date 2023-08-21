using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_semana_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaSimple lista = new ListaSimple();
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("1. insertar");
                Console.WriteLine("2. mostrar");
                Console.WriteLine("3. salir");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        ingresarAlumno();
                        Console.WriteLine("Dale al Enter para volver al menu...");
                        break;
                    case 2:
                        lista.mostrar();
                        Console.WriteLine("Dale al Enter para volver al menu...");

                        break;
                    case 3:
                        Console.WriteLine("Dale al Enter para confirmar...");

                        break;
                    default:
                        Console.WriteLine("error");
                        Console.WriteLine("Dale al Enter para volver al menu...");

                        break;
                }
            } while (op != 3);
            Console.ReadKey();

            void ingresarAlumno()
            {
                Console.WriteLine("Crear Aluno");
                Console.Write("nombres: ");
                string nombres = Console.ReadLine();
                Console.Write("edad: ");
                int edad = int.Parse(Console.ReadLine());

                Persona persona = new Persona(nombres, edad);
                lista.insertar(persona);

            }
        }
    }
}
