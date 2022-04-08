using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDoblementeEnlazada
{
    class Lista
    {
        Nodo primero = new Nodo();
        Nodo ultimo = new Nodo();
    
        public Lista()
        {
            primero = null;
            ultimo = null;
        }
        public void insertarNodo()
        {
            Nodo nuevo = new Nodo();
            Console.Write("Ingrese un valor para el nuevo nodo: ");
            nuevo.dato = int.Parse(Console.ReadLine());
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
                primero.siguiente = primero;
                primero.atras = ultimo;
            }
            else
            {
                ultimo.siguiente = nuevo;
                nuevo.atras = ultimo;
                nuevo.siguiente = primero;
                ultimo = nuevo;
                primero.atras = ultimo;
            }
            Console.WriteLine("\n Nuevo nodo ingresado con éxito \n\n");
        }
            public void DesplegarListaPU() 
            { 
                Nodo actual = new Nodo();
                actual = primero;
                if (actual != null)
                {
                    do 
                    {
                        Console.WriteLine(" " + actual.dato);
                        actual = actual.siguiente;
                    } while (actual != primero);
                }
                else 
                {
                    Console.WriteLine("\n La lista se encuentra vacía \n");
                }
            }
        public void desplegarListaUP() 
        {
            Nodo actual = new Nodo();
            actual = ultimo;
            if (actual != null)
            {
                do
                {
                    Console.WriteLine(" " + actual.dato);
                    actual = actual.atras;
                } while (actual != ultimo);
            }
            else 
            {
                Console.WriteLine("\n La lista se encuentra vacía \n");
            }
        }
    }
}
