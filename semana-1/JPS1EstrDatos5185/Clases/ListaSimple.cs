using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ListaSimple
    {
        public Nodo primero=null;

     public void insertar(int elemento) {
            Nodo temporal = primero;
            Nodo nuevo = new Nodo();         
            nuevo.dato = elemento;
        if (primero==null)
        {
           primero = nuevo; 
        }   
        else
        {             
             while (temporal.siguiente!=null)
             {
               temporal = temporal.siguiente;
             }
                temporal.siguiente = nuevo;
        }
        }

     public void mostrar() {
            Nodo temporal = primero;
            while (temporal!=null)
            {
                //imprimir
                Console.Write(temporal.dato+"->");
                temporal = temporal.siguiente;  
            }
            //mensaje
        }

    public void eliminar() { }
    }
}
