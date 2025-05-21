

/*
    * 62 - Instancia un objeto 
    * de la clase Persona y 
    * asígnale valores a sus 
    * propiedades.
*/

class Persona
{
    public string Nombre { get; set; }
    public int Edad {  get; set; }

    static void Main(string[] args)
    {
        Persona persona = new Persona();
        persona.Nombre = "Roldan";
        persona.Edad = 35;

        Console.WriteLine(persona.Nombre);
        Console.WriteLine(persona.Edad);
    }
}