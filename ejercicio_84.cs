

/*
 * 84 -  Escribe un programa para 
 * Copiar un archivo
*/

using System.IO;
public class Archivo
{
    public void Copiar(string origen, string destino)
    {
        File.Copy(origen, destino, true);
        Console.WriteLine("Archivo copiado!!");
    }
}
class Program
{
    static void Main()
    {
        string origen = "D:\\Documentos\\2025\\proyectosCsharp\\Cero_a_cien\\Cero_a_cien\\archivos\\archivo.txt";
        string destino = "D:\\Documentos\\2025\\proyectosCsharp\\Cero_a_cien\\Cero_a_cien\\archivos\\archivo2.txt";

        Archivo archivo = new Archivo();
        archivo.Copiar(origen, destino);
    }
}
