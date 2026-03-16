public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Suma.Sumar(1, 2));
        Console.WriteLine(Resta.Restar(3, 4));
        Console.WriteLine(Multiplicacion.Multiplicar(5, 6));
        Console.WriteLine(Division.Dividir(7, 8));
    }
}

// Esta clase implementa la operación resta
public class Resta
{
   public static int Restar(int a, int b)
   {
       return 0;
   }
}