using System;

namespace Application 
{
  //the class
  class Car
  {
    string model;
    string color;
    int year;
    
    static void Main(string[] args)
    {
      Car Ford = new Car();
      Ford.model = "Mustang";
      Ford.color = "red";
      Ford.year = 1969;
      
      Car Opel = new Car();
      Opel.model = "Astra";
      Opel.color = "white";
      Opel.year = 2005;
      
      Console.WriteLine(Ford.model);
      Console.WriteLine(Opel.model);
    }
  }
  
}
