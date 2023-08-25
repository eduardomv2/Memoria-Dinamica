using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoria_Dinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista dinámica de enteros
            List<int> numeros = new List<int>();

            // Agregar elementos a la lista
            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(30);

            Console.WriteLine("Elementos en la lista:");
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }

            // Eliminar el segundo elemento de la lista (20)
            numeros.RemoveAt(1);

            Console.WriteLine("\nElementos después de eliminar:");
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }

            // Liberar la memoria dinámica automáticamente cuando 'numeros' ya no se necesita

            // Esperar para que se vea la salida en la consola
            Console.ReadKey();
        }
    }
    
}
