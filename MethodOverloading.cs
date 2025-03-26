using System;

namespace Application 
{
  class Program
  {
    static int PlusMethodInt(int x, int y)
    {
      return x +y;
    }
    static double PlusMethodDouble(double x, double y)
    {
      return x+y;
    }
    static void Main(string[] args)
    {
      int myNum1 = PlusMethodInt(10,13);
      double myNum2 = PlusMethodDouble(4.3,4.34);
      Console.WriteLine("Int: "+ myNum1);
      Console.WriteLine("Double: "+ myNum2);
    }
  }
  
}
