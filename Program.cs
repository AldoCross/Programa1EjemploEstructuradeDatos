using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa1_ejemplo_estructura_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estructura de dato de tipo Cola
            // inicializacion del objeto Queue
            Queue<string> Cola = new Queue<string>();
            // metodo para meter dato.
            Cola.Enqueue("\n Juan "); // primero en entrar a la cola.
            Cola.Enqueue(" Juana "); // Segundo en entrar a la cola.
            Cola.Enqueue(" Mario "); // Tercero en entrar a la cola.
            Cola.Enqueue(" Maria "); // Cuarto en entrar a la cola.
            
            while (Cola.Count>0)
            {
                Console.WriteLine(Cola.Dequeue()); // metodo para sacar dato.
            }
            

            // Estructura de Dato de Tipo Pila:
            // inicializacion del objeto Stack
            Stack<string>Pila = new Stack<string>();
            // metodo para apilar el dato
            Pila.Push(" Tortilla 1 ");
            Pila.Push(" Tortilla 2 ");
            Pila.Push(" Tortilla 3 ");
            Pila.Push("\n Tortilla 4 ");

            while (Pila.Count>0)
            {
                Console.WriteLine(Pila.Pop()); // metodo para desapilar el dato
            }
            Console.ReadKey();

        }
    }
}
