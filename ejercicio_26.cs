using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        * 26 - Escribe un programa
        * que compare dos cadenas
        * y muestre un mensaje
        * si son iguales.
        */
        string cadena1 = "hola";
        string cadena2 = "holaa";
        
        if (cadena1 == cadena2)
        {
            Console.WriteLine("Cadenas iguales");
        }
        else
        {
            Console.WriteLine("Cadenas no iguales");
        }
    }
}