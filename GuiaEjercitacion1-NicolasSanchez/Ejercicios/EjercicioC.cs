namespace Ejercicios;

public class EjercicioC
{
  // ============================================
  // SECCIÓN C — Pregunta 1
  // Cual es el error?: Este es el error "public double Calcular()"
  // Como se corrige?: Se corrige agregandole override a la funcion.
  //                   Quedaria asi "public override double Calcular()"
  // ============================================

  // ============================================
  // SECCIÓN C — Pregunta 2
  // Cual es el error?: La clase de CuentaCorriente esta llamando a una variable privada y sin hacer referencia de la clase donde pertenece.
  // Como se corrige?: Se podria crear un setter para la variable de "saldo", asi mantiene su propiedad privada.
  //                   Luego la funcion CuentaCorriente.Depositar() en ves de usar saldo, podria usar el setter de saldo.
  //                   De esa forma, mantiene su propiedad privada y puede ser usada en la clase CuentaCorriente.
  //                   Otra forma seria agregarle public a la variable de "saldo" y hacer la referencia correspondiente "CuentaBancaria.saldo", pero no mantiene su propiedad privada.
  // El setter podria ser asi: public void SetSaldo(double saldo) { this.saldo = saldo; }
  // Y la funcion podria quedar asi: public void Depositar(double monto) { SetSaldo(CuentaBancaria.ObtenerSaldo() + monto); }
  // ============================================

  // ============================================
  // SECCIÓN C — Pregunta 3
  // Cual es el error?: La clase Documento no esta implementando todos los metodos de la interfaz, por lo que daria un error.
  // ¿Qué necesita agregar Documento para compilar?: La clase Documento deberia implementar los metodos Guardar() y EstaGuardado().
  // Si se les agrega estos metodos, la clase Documento compilaria correctamente.
  // ============================================
}