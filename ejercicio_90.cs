



/*
 * 90 -  Escribe un programa para 
 * reemplazar texto en un archivo
*/

using System.IO;
public class Archivo
{
    public void Reemplazar(string ruta, string buscar, string reemplazar)
    {
        if (File.Exists(ruta))
        {
            string contenido = File.ReadAllText(ruta);
            contenido = contenido.Replace(buscar, reemplazar);
            File.WriteAllText(ruta, contenido );
            Console.WriteLine("Texto reemplazado");
        } else
        {
            Console.WriteLine("No existe el archivo");
        }
    }
}
class Program
{
    static void Main()
    {
        string ruta = "D:\\Documentos\\2025\\proyectosCsharp\\Cero_a_cien\\Cero_a_cien\\archivos\\archivo.txt";
        Archivo archivo = new Archivo();
        archivo.Reemplazar(ruta,"b", "ejercicio 90");
    }
}
