namespace Ejercicios;

public class EjercicioD_1
{
    //asd
    public class Persona
  {
    public string Nombre { get; private set; }
    public int Edad { get; private set; }
    public Persona(string nombre, int edad)
    {
      this.Nombre = nombre;
      this.Edad = edad;
    }
    public virtual void Saludar()
    {
      Console.WriteLine("Hola, soy " + Nombre + ", tengo " + Edad + "años.");
    }
  }
public class Estudiante : Persona
  {
    public string Carrera { get; private set; }
    public Estudiante(string nombre, int edad, string carrera) : base(nombre, edad)
    {
      this.Carrera = carrera;
    }
    public override void Saludar()
    {
      Console.WriteLine("Soy " + Nombre + ", estudiante de " + Carrera + ".");
    }
  }

}

public class EjercicioD_2
{
  public interface ICalculable
  {
    double Calcular();
    string Descripcion();
  }
  public class Circulo : ICalculable
  {
    public double Radio { get; private set; }
    public Circulo(double radio) { Radio = radio; }
    public double Calcular() {
      return 3.14 * Radio * Radio;
    }
    public string Descripcion() {
      return "Circulo de radio " + Radio;
    }
  }

}