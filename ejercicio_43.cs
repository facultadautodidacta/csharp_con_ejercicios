using System;

class Program
{
    static void Main(string[] args)
    {
        /*
         * 43 -  Suma todos los elementos 
         * de un array de enteros.
         */

        int[] numeros = { 1, 2, 3, 4, 5 };
        int sumaTotal = 0;

        foreach (int i in numeros)
        {
            sumaTotal = sumaTotal + i;
        }

        Console.WriteLine(sumaTotal);
    }
}