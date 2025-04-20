class Program
{
    static void Main(string[] args)
    {
        /*  
        * 24 - Usa el operador ternario  
        * para determinar  
        * si un número es par o impar  
        */  
        /*  
        * Operador ternario:  
        * Es una forma compacta de escribir  
        * una condición if-else.  
        */  
        int numero = 10;  
        string r = (numero % 2 == 0) ? "Par" : "Impar"; 
        Console.WriteLine(r);  
    }
}