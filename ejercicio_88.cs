



/*
 * 88 -  Escribe un programa para 
 * contar líneas de un archivo
*/

using System.IO;
public class Archivo
{
    public int ContarLineas(string ruta)
    {
        if (File.Exists(ruta))
        {
            return File.ReadAllLines(ruta).Length;
        } else
        {
            return 0;
        }
    }
}
class Program
{
    static void Main()
    {
        string ruta = "D:\\Documentos\\2025\\proyectosCsharp\\Cero_a_cien\\Cero_a_cien\\archivos\\archivo.txt";
        Archivo archivo = new Archivo();
        int total = 0;
        total = archivo.ContarLineas(ruta);
        Console.WriteLine(total);

    }
}
