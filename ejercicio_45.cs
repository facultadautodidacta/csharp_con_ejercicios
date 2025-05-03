using System;

class Program
{
    static void Main(string[] args)
    {
        /*
         * 45 - Ordena un array de 
         * enteros de menor a mayor.
         */

        int[] numeros = { 21, 7, 3, 4, 5 };

        Array.Sort(numeros);

        Console.WriteLine(string.Join(",", numeros));
    }
}