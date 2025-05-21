/*
    * 63 - Añade un método Saludar 
    * a la clase Persona que 
    * imprima un saludo.

*/

class Persona
{
    public string Nombre { get; set; }
    public int Edad {  get; set; }
    public void saludar()
    {
        Console.WriteLine($"Hola {this.Nombre}");
    }

    static void Main(string[] args)
    {
        Persona persona = new Persona();
        persona.Nombre = "Roldan";
        persona.saludar();
    }
}