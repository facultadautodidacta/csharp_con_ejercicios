



/*
 * 95 -  Crea un programa que convierta 
 * entre diferentes divisas.
*/

class Convertir
{
    private double tasaDolar = 20; //MXN
    public double ConvertirDolar(double pesos)
    {
        return pesos / this.tasaDolar;
    }

    public double ConvertirPesos(double dolar)
    {
        return dolar * tasaDolar;
    }
}

class Program
{
    static void Main()
    {
        Convertir convertir = new Convertir();
        double pesos = 2000;
        double dolares = 20;
        double resultadop = convertir.ConvertirDolar(pesos);
        double resultadop2 = convertir.ConvertirPesos(dolares);

        Console.WriteLine($"Conversion pesos a dolar {resultadop}");
        Console.WriteLine($"Conversion dolar a pesos {resultadop2}");
    }
}
