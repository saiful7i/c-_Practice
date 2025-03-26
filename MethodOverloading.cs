using System;

namespace Application 
{
  class Program
  {
    static int PlusMethod(int x, int y)
    {
      return x +y;
    }
    static double PlusMethod(double x, double y)
    {
      return x+y;
    }
    static void Main(string[] args)
    {
      int myNum1 = PlusMethod(10,13);
      double myNum2 = PlusMethod(4.3,4.34);
      Console.WriteLine("Int: "+ myNum1);
      Console.WriteLine("Double: "+ myNum2);
    }
  }
  
}
