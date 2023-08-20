using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ListaSimple
    {
        public Nodo primero = null;

        public void insertar(Persona persona)
        {
            Nodo temporal = primero;
            Nodo nuevo = new Nodo();
            nuevo.persona = persona;
            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                while (temporal.sig != null)
                {
                    temporal = temporal.sig;
                }
                temporal.sig = nuevo;
            }
        }

        public void mostrar()
        {
            Nodo temporal = primero;
            while (temporal != null)
            {
                //imprimir
                //Console.Write(temporal.dato + "->");
                temporal.persona.mostrarPersona();
                temporal = temporal.sig;
            }
            //mensaje
        }

        public void eliminar() { }

    }
}
