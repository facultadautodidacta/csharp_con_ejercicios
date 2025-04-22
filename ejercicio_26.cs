using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Comparador de cadenas");
        Console.Write("Ingrese la primera cadena: ");
        string cadena1 = Console.ReadLine();
        
        Console.Write("Ingrese la segunda cadena: ");
        string cadena2 = Console.ReadLine();
        
        if (cadena1 == cadena2)
        {
            Console.WriteLine("Las cadenas son iguales");
        }
        else
        {
            Console.WriteLine("Las cadenas son diferentes");
        }
    }
}