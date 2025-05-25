



/*
 * 82 -  Escribe un programa para 
 * Leer un archivo
*/

using System.IO;
public class Archivo
{
    public void Leer(string ruta)
    {
        if (File.Exists(ruta))
        {
            string contenido = File.ReadAllText(ruta);
            Console.WriteLine(contenido);
        }
    }
}
class Program
{
    static void Main()
    {
        string ruta = "D:\\Documentos\\2025\\proyectosCsharp\\Cero_a_cien\\Cero_a_cien\\archivos\\archivo.txt";
        Archivo archivo = new Archivo();
        archivo.Leer(ruta);
    }
}
