using Ejercicios;

namespace Ejercicios;

public class Perro : Animal, IEntrenable, IVacunable
{
  public bool EstaEntrenado { get; private set; }
  public bool EstaVacunado { get; private set; }

  public Perro(string nombre, int edad) : base(nombre, edad)
  {
    EstaEntrenado = false;
    EstaVacunado = false;
  }

  public override void Hablar()
  {
    Console.WriteLine("Guau!");
  }

  public override void Descripcion()
  {
    base.Descripcion();
    Console.WriteLine($"Esta entrenado: {EstaEntrenado}");
    Console.WriteLine($"Esta vacunado: {EstaVacunado}");
  }

  public void Entrenar()
  {
    EstaEntrenado = true;
  }

  public void Vacunar()
  {
    EstaVacunado = true;
  }
}
