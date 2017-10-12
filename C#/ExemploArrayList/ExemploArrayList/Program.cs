using System;
using System.Collections;

namespace ExemploArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList AL = new ArrayList();
            Console.WriteLine("\nCapacidade de elementos = {0}\nQuantidade de elementos = {1}", AL.Capacity, AL.Count);
            AL.Add(1);
            Console.WriteLine("\nCapacidade de elementos = {0}\nQuantidade de elementos = {1}", AL.Capacity, AL.Count);
            AL.Add(2);
            Console.WriteLine("\nCapacidade de elementos = {0}\nQuantidade de elementos = {1}", AL.Capacity, AL.Count);
            Console.ReadKey();
        }
    }
}
