



/*
 * 81 -  Crear y escribir en un archivo
*/

using System.IO;
public class Archivo
{
    public void CrearEscribir(string ruta, string texto)
    {
        File.WriteAllText(ruta, texto);
        Console.WriteLine("Exito!");
    }
}
class Program
{
    static void Main()
    {
        string ruta = "D:\\Documentos\\2025\\proyectosCsharp\\Cero_a_cien\\Cero_a_cien\\archivos\\archivo.txt";
        Archivo archivo = new Archivo();
        archivo.CrearEscribir(ruta, "Hola mundo!");
    }
}
