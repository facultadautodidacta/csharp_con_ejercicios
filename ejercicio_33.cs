class Program
{
    static void Main(string[] args)
    {
        /*
        * 33 - Escribe un programa
        * que imprima los números
        * del 1 al 10 usando un bucle do-while.
        */
        int contador = 1; //i
        do
        {
            Console.WriteLine(contador);
            contador++;
        } while (contador <= 10);
    }
}