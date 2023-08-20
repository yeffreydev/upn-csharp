using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
                        Console.WriteLine("ingrese elemento: ");
                        int e = int.Parse(Console.ReadLine());
                        lista.insertar(e);
                        break;
                        case 2:
                        lista.mostrar();
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                Console.ReadKey();
            } while (op!=3);
        }
    }
}
