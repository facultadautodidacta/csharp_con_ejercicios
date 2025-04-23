using System;

class Program
{
    static void Main(string[] args)
    {
        /*
         * 34 - Escribe un programa 
         * que imprima una tabla 
         * de multiplicar usando for.
         */

        int numero = 5;
        int m = 0; //multiplicacion

        for (int i = 1; i < 11; i++)
        {
            m = i * numero;
            Console.WriteLine(numero + "x" + i + "=" + m);
        }
    }
}