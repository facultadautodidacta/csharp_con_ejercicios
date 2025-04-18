class Program
{
    static void Main(string[] args)
    {
        /*  
        * 14 - Pide al usuario que escriba su nombre por  
        * consola, obten el total de caracteres del nombre,  
        * sumale un número de punto flotante y  
        * muestra el resultado.  
        */  
        Console.WriteLine("Escribe tu nombre!");  
        string nombre = Console.ReadLine();  
        int caracteres = nombre.Length;  
        double resultado = caracteres + 0.5;  
        Console.WriteLine(resultado);  
    }
}
