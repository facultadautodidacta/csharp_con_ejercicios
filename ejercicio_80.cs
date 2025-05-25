

/*
 * 80 -  Escribe un programa 
 * que maneje excepciones 
 * dentro de un bucle.
*/

class Program
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4, 5 };

        for (int i = 0; i < numeros.Length; i++)
        {
            try
            {
                Console.WriteLine(numeros[8]);
            }
            catch (IndexOutOfRangeException) 
            { 
                Console.WriteLine("indice fuera de rango");
            }
        }

    }
}

