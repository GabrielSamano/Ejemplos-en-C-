using System;

namespace Operadores
{
  class Program
  {
    static void Main(string[] args)
    {
      int sum1 = 100 + 50;     // (100 + 50) = 150
      int sum2 = sum1 + 250;   // (150 + 250) = 400
      int sum3 = sum2 + sum2;  // (400 + 400) = 800
      Console.WriteLine(sum1);
      Console.WriteLine(sum2);
      Console.WriteLine(sum3);
     }
  }
}
