class Program
{
    static void Main(string[] args)
    {
        /*
        * 15 - Convierte una variable de
        * tipo int a float y viceversa.
        */
        //convertir a float
        int entero = 42;
        float flotante = entero;
        Console.WriteLine(flotante);
        //convertir a int
        float flotante2 = 42.5f;
        int entero2 = (int)flotante2;
        Console.WriteLine(entero2);
    }
}
