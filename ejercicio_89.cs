



/*
 * 89 -  Escribe un programa para 
 * buscar una palabra en el archivo
*/

using System.IO;
public class Archivo
{
    public void Buscar(string ruta, string palabra)
    {
        var lineas = File.ReadAllLines(ruta);
        for (int i = 0; i < lineas.Length; i++)
        {
            if (lineas[i].Contains(palabra))
            {
                Console.WriteLine($"encontrado en la linea {i + 1}");
            }
        }
    }
}
class Program
{
    static void Main()
    {
        string ruta = "D:\\Documentos\\2025\\proyectosCsharp\\Cero_a_cien\\Cero_a_cien\\archivos\\archivo.txt";
        Archivo archivo = new Archivo();
        archivo.Buscar(ruta, "mundo");
    }
}
