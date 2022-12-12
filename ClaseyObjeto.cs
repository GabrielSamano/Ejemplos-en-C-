using System;

namespace MyApplication
{
  class Car    // Se crea la clase car
  {
    string color = "red";  // Se crea un objeto dentro de la clase 

    static void Main(string[] args)
    {
      Car myObj = new Car();
      Console.WriteLine(myObj.color);   // se imprime el objeto 
    }
  }
}
