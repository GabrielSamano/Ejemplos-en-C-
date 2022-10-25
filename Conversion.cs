using System;

namespace ConversionD
{
  class Program
  {
    static void Main(string[] args)
    {
      double myDouble = 5.15;
      int myInt = (int) myDouble;  // Conversion de tipo flotante a entero 

      Console.WriteLine(myDouble);
      Console.WriteLine(myInt);
    }
  }
}
