using System;

namespace Metodo
{
  class Aplicacion
  {
    static void MyMethod()
    {
      Console.WriteLine("Llamando al metodo"); // Se crea el metodo con su contenido para despues ser llamado
    }

    static void Main(string[] args)
    {
      MyMethod();  // Se llama al metodo 
    }
  }
}
