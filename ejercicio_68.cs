

/*
    * 68 - Crear una clase Cliente 
    * con un constructor que reciba 
    * Nombre y Edad, y método MostrarDatos
*/

class Cliente
{
    public string Nombre { get; set; }
    public int Edad {  get; set; }
    public Cliente(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
    public void MostrarDatos()
    {
        Console.WriteLine(Nombre);
        Console.WriteLine(Edad);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Cliente cliente = new Cliente("Roldan", 35);
        cliente.MostrarDatos();
    }
}