



/*
 * 93 -  Crea una aplicación que permita 
 * añadir, eliminar y mostrar tareas.
*/

class ListaTareas
{
    private List<string> tareas = new List<string>();
    public void Agregar(string tarea) => tareas.Add(tarea);
    public void Eliminar(int indice)
    {
        if (indice >= 0 && indice < tareas.Count)
        {
            this.tareas.RemoveAt(indice);
        }
    }
    public void Mostrar()
    {
        Console.WriteLine("Lista de tareas");
        int numero = 1;
        foreach (string tarea in tareas) 
        {
            Console.WriteLine(numero++ + tarea);
        }
    }
}
class Program
{
    static void Main()
    {
        ListaTareas tareas = new ListaTareas();
        tareas.Agregar("Estudiar C#");
        tareas.Agregar("Ver los 100 ejercicios");
        tareas.Mostrar();
        tareas.Eliminar(0);
        tareas.Mostrar();
    }
}
