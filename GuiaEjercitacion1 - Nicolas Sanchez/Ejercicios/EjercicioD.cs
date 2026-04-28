namespace Ejercicios;

public class EjercicioD
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