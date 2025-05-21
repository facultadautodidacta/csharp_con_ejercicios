

/*
    * 66 - Sobrescribe el método 
    * Saludar en la clase Estudiante.
*/
class Estudiante : Persona
{
    public string Matricula { get; set; }
    public override string saludar()
    {
        return "Hola estudiante";
    }
}
class Persona
{
    public string Nombre { get; set; }
    public int Edad {  get; set; }
    public virtual string saludar()
    {
        return $"Hola {this.Nombre}";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Persona persona = new Persona();
        persona.Nombre = "nombre 1";
        Console.WriteLine(persona.saludar());
    }
}