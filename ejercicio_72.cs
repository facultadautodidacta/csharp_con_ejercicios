/*
 * 72 - Convierte texto a número y 
 * maneja la excepción
*/

class Calcular
{
    public void Convertir(string numText)
    {
        try
        {
            int numero = 0;
            numero = int.Parse(numText);
            Console.WriteLine(numero);
        }
        catch (FormatException) 
        {
            Console.WriteLine("Numero invalido");
        }
    }
}
class Program
{
    static void Main()
    {
        Calcular calcular = new Calcular();
        calcular.Convertir("2");
        calcular.Convertir("M");
    }
}