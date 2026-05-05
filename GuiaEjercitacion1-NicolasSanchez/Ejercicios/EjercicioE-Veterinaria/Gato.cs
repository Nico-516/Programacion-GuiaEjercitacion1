using Ejercicios;

namespace Ejercicios;

public class Gato : Animal, IVacunable
{
  public bool EstaVacunado { get; private set; }

  public Gato(string nombre, int edad) : base(nombre, edad)
  {
    EstaVacunado = false;
  }

  public override void Hablar()
  {
    Console.WriteLine("Miau!");
  }

  public override void Descripcion()
  {
    base.Descripcion();
    Console.WriteLine($"Esta vacunado: {EstaVacunado}");
  }

  public void Vacunar()
  {
    EstaVacunado = true;
  }
}
