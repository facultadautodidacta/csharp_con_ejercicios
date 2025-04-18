class Program
{
    static void Main(string[] args)
    {
        /*
        * 13 - Pide al usuario un numero
        * de punto flotante, multiplicalo
        * por dos y muestra el resultado
        */
        Console.WriteLine("Ingresa un numero decimal");
        double numero = Convert.ToDouble(Console.ReadLine());
        double resultado = numero * 2;
        Console.WriteLine(resultado);
    }
}
