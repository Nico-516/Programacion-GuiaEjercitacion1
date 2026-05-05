using Ejercicios;

public class Program
{
  static List<Animal> pets = new List<Animal>();

  public static void Main()
  {
    int opcionMenu = -1;
    int opcionSubMenu = -1;

    do{
      MostrarMenu();
      opcionMenu = StringToInt(Console.ReadLine());
      switch (opcionMenu)
      {
        case 1:
          ExerciseD_1();
          break;
        case 2:
          ExerciseD_2();
          break;
        case 3:
          do{
            VeterinariaMenu();
            opcionSubMenu = StringToInt(Console.ReadLine());
            switch (opcionSubMenu)
            {
              case 1:
                AddPet(pets);
                break;
              case 2:
                PetsInfo(pets);
                break;
              case 3:
                VaccinateAll(pets);
                break;
              case 4:
                TrainAll(pets);
                break;
              case 9:
                Console.WriteLine("Volviendo al menú principal...");
                break;
              default:
                Console.WriteLine("Opcion no valida");
                break;
            }
          }while(opcionSubMenu != 9);
          break;
        case 0:
          Console.WriteLine("Adiós.");
          return;
        default:
          Console.WriteLine("Opcion no valida");
          break;
      }
    }while(opcionMenu != 0);
  }
  
  static void PetsInfo(List<Animal>pets){
    Console.WriteLine("=== INFORMACION DE LAS MASCOTAS ===");
    if (pets.Count == 0)
    {
      Console.WriteLine("No hay mascotas registradas");
    }
    else
    {
      foreach(Animal pet in pets){
        pet.Descripcion();
        pet.Hablar();
      }
    }
  }
  
  static void AddPet(List<Animal>pets){
    Console.WriteLine("=== AGREGAR MASCOTA ===");
    Console.Write("Ingrese el Nombre de la mascota: ");
    string name = StringValidate(Console.ReadLine());
    Console.Write("Ingrese la edad de la mascota: ");
    int age = StringToInt(Console.ReadLine());
    Console.Write("Ingrese la especie de la mascota (perro/gato): ");
    string type = StringValidate(Console.ReadLine());
    switch (type.ToLower())
    {
      case "perro":
        pets.Add(new Perro(name, age));
        break;
      case "gato":
        pets.Add(new Gato(name, age));
        break;
      default:
        Console.WriteLine("Tipo de mascota no reconocido");
        break;
    }
    Console.WriteLine("Mascota agregada exitosamente!");
  }
  
  static void VaccinateAll(List<Animal>pets){
    if(pets.Count > 0){
      foreach(var pet in pets){
        if(pet is IVacunable){
          ((IVacunable)pet).Vacunar();
        }
      }
      Console.WriteLine("Todas las mascotas han sido vacunadas");
    }else{
      Console.WriteLine("No hay mascotas registradas");
    }
  }
  
  static void TrainAll(List<Animal>pets){
    if(pets.Count > 0){
      foreach(var pet in pets){
        if(pet is IEntrenable){
          ((IEntrenable)pet).Entrenar();
        }
      }
      Console.WriteLine("Todos los perros han sido entrenados");
    }else{
      Console.WriteLine("No hay mascotas registradas");
    }
  }
  
  static void ExerciseD_1(){
    Console.WriteLine("=== EJERCICIO D - Pregunta 1 ===");
    EjercicioD_1.Persona persona = new EjercicioD_1.Persona("Juan", 20);
    persona.Saludar();
    EjercicioD_1.Estudiante estudiante = new EjercicioD_1.Estudiante("Maria", 22, "Informatica");
    estudiante.Saludar();
    Console.WriteLine("");
  }
  
  static void ExerciseD_2(){
    Console.WriteLine("=== EJERCICIO D - Pregunta 2 ===");
    EjercicioD_2.ICalculable figura = new EjercicioD_2.Circulo(5);
    Console.WriteLine(figura.Descripcion() + " Area: " + figura.Calcular());
    Console.WriteLine("");
  }
  
  static void VeterinariaMenu(){
    Console.WriteLine("=== VETERINARIA ===");
    Console.WriteLine("1) Agregar Mascota");
    Console.WriteLine("2) Mostrar Mascotas");
    Console.WriteLine("3) Vacunar a todos");
    Console.WriteLine("4) Entrenar a todos");
    Console.WriteLine("9) Volver al menú principal");
  }
  
  static void MostrarMenu(){
    Console.WriteLine("\n\n === Nicolas Sanchez | Guia de Ejercicios ===\n");
    Console.WriteLine("1) Probar ejercicio D-1");
    Console.WriteLine("2) Probar ejercicio D-2");
    Console.WriteLine("3) Probar ejercicio E");
    Console.WriteLine("0) Salir");
  }

  static string StringValidate(string? text, string mensaje="El valor ingresado no puede estar vacio."){
    bool verified;
    string result = "";
    do{
      if (String.IsNullOrWhiteSpace(text)){
        Console.Write(mensaje);
        text = Console.ReadLine();
        verified = false;
      }else{
        result = text;
        verified = true;
      }
    }while(verified == false);
    Console.Clear();
    return result;
  }

  static int StringToInt(string? text, string mensaje="El valor ingresado no es un numero"){
    bool verified = false;
    int result;
    do{
      if (int.TryParse(text, out result)){
        verified = true;
      }else{
        Console.WriteLine(mensaje);
        text = StringValidate(Console.ReadLine());
      }
    }while(verified == false);
    Console.Clear();
    return result;
  }
}