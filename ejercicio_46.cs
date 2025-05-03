using System;

class Program
{
    static void Main(string[] args)
    {
        /*
         * 46 - Declara una lista de enteros 
         * y asígnale valores.
         */

        List<int> numeros = new List<int>();

        numeros.Add(100);

        Console.WriteLine(string.Join(",", numeros));
        
    }
}