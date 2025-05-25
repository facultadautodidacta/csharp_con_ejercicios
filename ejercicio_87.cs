



/*
 * 87 -  Escribe un programa para 
 * leer un archivo línea por línea
*/

using System.IO;
public class Archivo
{
    public void LeerLineas(string ruta)
    {
        if (File.Exists(ruta))
        {
            string[] lineas = File.ReadAllLines(ruta);
            foreach (string line in lineas) 
            {
                Console.WriteLine(line);
            }
        } else
        {
            Console.WriteLine("Archivo no encontrado");
        }
    }
}
class Program
{
    static void Main()
    {
        string ruta = "D:\\Documentos\\2025\\proyectosCsharp\\Cero_a_cien\\Cero_a_cien\\archivos\\archivo.txt";
        Archivo archivo = new Archivo();
        archivo.LeerLineas(ruta);

    }
}
