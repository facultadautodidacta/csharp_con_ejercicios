class Program
{
    static void Main(string[] args)
    {
        /*
        * 20 - Usa el formateo de
        * cadenas para mostrar
        * una fecha en formato
        * (dia/mes/año).
        */
        DateTime fecha = DateTime.Now;
        string formato = fecha.ToString("dd/MM/yyyy");
        Console.WriteLine(formato);
    }
}
