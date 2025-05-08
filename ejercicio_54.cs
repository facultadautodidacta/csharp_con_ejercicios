class Program
{
    public static string saludar(string nombre = "Mundo")
    {
        return "hola " + nombre;
    }
    static void Main(string[] args)
    {
        /*
         * 54 - Escribe una función 
         * que tome un parámetro opcional.
         */
        string nombre = "roldan";
        Console.WriteLine(saludar(nombre));

    }
}