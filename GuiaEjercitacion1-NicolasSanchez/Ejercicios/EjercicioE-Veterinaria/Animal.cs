namespace Ejercicios;

public abstract class Animal
{
  public string _nombre { get; protected set; }
  public int _edad { get; protected set; }

  public Animal(string nombre, int edad)
  {
    _nombre = nombre;
    _edad = edad;
  }

  public virtual void Hablar()
  {
    Console.WriteLine("El animal hace ruido...");
  }

  public virtual void Descripcion()
  {
    Console.WriteLine($"Nombre: {_nombre}, Edad: {_edad}");
  }
}
