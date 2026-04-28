namespace Ejercicios;

public class EjercicioB
{
  // ============================================
  // SECCIÓN B — Pregunta 1
  // Imprime:  "Color: rojo Area: 78.5"
  //           "Color: azul Area: 16"
  //
  // Explicacion: La funcion Mostrar() es parte de clase padre abstracta Figura.
  //              Mostrar consta de imprimir 2 variables, color y area.
  //              En los constructores de Circulo y Rectangulo el parametro de Area es el unico que difiere al ser abstracto.
  //              Por lo que la razon de que los numeros impresos sean tan distintos, es porque Area tiene
  //              un metodo distinto dependiando de si la clase es Circulo o Rectangulo.
  // ============================================

  // ============================================
  // SECCIÓN B — Pregunta 2
  // Imprime: "Rex dice: Guau!"
  //          "Misi dice: Miau!"
  //          "Bobi dice: Guau!"
  // 
  // ¿Podría existir un objeto Animal en la lista? ¿Por qué?: No, no podria existir un objeto Animal en la lista.
  // Porque la lista animales es de tipo "ISonido", y Animal no implementa esa interfaz. Pero Perro y Gato si implementan ISonido, por eso pueden existir en la lista.
  // ============================================

  // ============================================
  // SECCIÓN B — Pregunta 3
  // Imprime: "Ford: nafta"
  //          "Toyota: diesel"
  //          "Tesla: electrico"
  // 
  // ¿Qué pasaría si quitás override de Auto.TipoMotor()?: Daria un error de compilacion, ya que la funcion padre al ser virtual,
  // al no poner override en las clases hijas, no se considerarian como funciones que pueden ser sobreescritas. Por lo que daria un error al intentar llamar a 
  // "TipoMotor()" en un objeto de tipo Auto.
  // ============================================
}