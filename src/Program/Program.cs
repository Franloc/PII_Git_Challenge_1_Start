public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Suma.Sumar(1, 2));
        Console.WriteLine(Resta.Restar(3, 4));
        Console.WriteLine(Multiplicacion.Multiplicar(5, 6));
        Console.WriteLine(Division.Dividir(7, 8));
    }

public class Division
{
    public static double Dividir(int a, int b)
    {
        return (double)a / b;
    }
}


public class Multiplicacion
{
   public static int Multiplicar(int a, int b)
   {
       return a * b;
   }
}
}