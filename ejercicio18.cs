class Program
{
    static void Main(string[] args)
    {
        /*
        * 18 - Escribe un programa
        * que tome una letra minúscula
        * como entrada,
        * avance 3 posiciones
        * en el alfabeto y
        * muestre la nueva letra.
        */
        Console.WriteLine("Escribe una letra");
        char letra = Console.ReadKey().KeyChar;
        char position = (char)(letra + 3);
        Console.WriteLine("---");
        Console.WriteLine(position);
    }
}
