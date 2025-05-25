



/*
 * 85 -  Escribe un programa para 
 * Mover un archivo
*/

using System.IO;
public class Archivo
{
    public void Mover(string origen, string destino)
    {
        File.Move(origen, destino);
        Console.WriteLine("Archivo movido");
    }
}
class Program
{
    static void Main()
    {
        string origen = "D:\\Documentos\\2025\\proyectosCsharp\\Cero_a_cien\\Cero_a_cien\\archivos\\archivo2.txt";
        string destino = "D:\\Documentos\\2025\\proyectosCsharp\\Cero_a_cien\\Cero_a_cien\\movidos\\archivo2.txt";
        Archivo archivo = new Archivo();
        archivo.Mover(origen, destino);

    }
}
