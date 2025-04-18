using System;

class Program
{
    static void Main(string[] args)
    {
        /*
         * 12 – Pide al usuario dos numeros,
         * súmalos y muestra el resultado
         */

        Console.WriteLine("Escribe 2 numeros");
        Console.WriteLine("Numero 1");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Numero 2");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int resultado = n1 + n2;
        Console.WriteLine(resultado);
    }
}
