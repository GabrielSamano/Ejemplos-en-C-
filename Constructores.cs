
using System;

namespace MyConstructor
{
  // Creaacion de una clase llamado car 
  class Car
  {
    public string model;  // Creacion del modelo

    // Creacion de el objeto car 
    public Car()
    {
      model = "Mustang"; // Valor inicial del modelo 
    }

    static void Main(string[] args)
    {
      Car Ford = new Car();  // Crear un objeto para llamarlo 
      Console.WriteLine(Ford.model);  // imprimiendo el valor del modelo 
    }
  }
}
