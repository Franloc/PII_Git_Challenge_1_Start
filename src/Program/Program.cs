public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Suma.Sumar(1, 4));
        Console.WriteLine(Resta.Restar(3, 4));
        Console.WriteLine(Multiplicacion.Multiplicar(5, 6));
        Console.WriteLine(Division.Dividir(7, 8));
        Console.WriteLine(Potencia.Elevar(2, 3));
    }
}

// Esta clase implementa la operación suma
public class Suma
{
   public static int Sumar(int a, int b)
   {
       return a + b;
   }
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

// Esta clase implementa la operación resta
public class Resta
{
   public static int Restar(int a, int b)
   {
       return a - b;
   }
}

public class Potencia
{
    public static int Elevar(int bas, int expo)
    {
        int resultado = 1;
        for (int i= 1; i<=expo; i++)
        {
           resultado = resultado * bas; 
        }
        return resultado;
    }
}