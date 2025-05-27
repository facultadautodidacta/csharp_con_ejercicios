using System;

/*
 *  92 - Crea un juego donde el usuario 
 *  deba adivinar un número aleatorio.

 */
class Adivinar
{
    private int numeroSecreto;
    private Random random;
    public Adivinar()
    {
        random = new Random();
        numeroSecreto = random.Next(1,11);
    }
    public void Jugar()
    {
        Console.WriteLine("Adivina el numero entre 1 y 10");
        Console.WriteLine("Escribe el numero ");
        int intento = int.Parse(Console.ReadLine());

        if (intento == this.numeroSecreto)
        {
            Console.WriteLine("Correcto!");
        } else
        {
            Console.WriteLine("Perdiste era " + numeroSecreto);
        }
    }
}
class Program
{
    static void Main()
    {
        Adivinar a = new Adivinar();
        a.Jugar();
    }
}