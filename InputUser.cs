using System;

namespace InputUser
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Ingresa tu edad:");
      int age = Convert.ToInt32(Console.ReadLine()); // se utiliza Convert.to para manejar el texto y numero 
      Console.WriteLine("Tu edad es: " + age);
    }
  }
}
