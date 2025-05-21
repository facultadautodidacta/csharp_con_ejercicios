/*
    * 64 - Añade un constructor
    * a la clase Persona que 
    * inicialice las propiedades.
*/
class Persona
{
    public string Nombre { get; set; }
    public int Edad {  get; set; }
    public Persona(string nombre, int edad) 
    {
        this.Nombre = nombre;
        this.Edad = edad;
    }
    public void saludar()
    {
        Console.WriteLine($"Hola {this.Nombre}");
    }

    static void Main(string[] args)
    {
        Persona persona = new Persona("Roldan", 35);
        persona.saludar();
    }
}