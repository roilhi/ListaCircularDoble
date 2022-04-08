using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDoblementeEnlazada 
{
    class Program 
    {
        static void Main(string[] args) 
        { 
            Lista l = new Lista();
            // Agregar nodos por medio del método insertar nodo, en este caso inserta 5 nodos
            l.insertarNodo();
            l.insertarNodo();
            l.insertarNodo();
            l.insertarNodo();
            l.insertarNodo();
            Console.WriteLine("Desplegar listas primero al último");
            /// Método para desplegar la lista del primero al último
            l.DesplegarListaPU();
            Console.WriteLine("Desplegar lista último al primero");
            // Método para desplegar la lista del último al primero
            l.desplegarListaUP();
            Console.ReadLine();
        }
    }

}
