using Ejercicios;

public class Program
{
    public static void Main(string[] args)
    {
      ICalculable figura = new Circulo(5);
      Console.WriteLine(figura.Descripcion() + " Area: " + figura.Calcular());
    }
}