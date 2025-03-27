using System;

namespace Program
//class for car 
{
  class Car
  {
    public string model;  //field of class
  
    public Car() //Car class Constructor
    {
      model = "Mustang"; //initial value of model
    }
    
    static void Main(string[] args)
    {
      Car Ford = new Car(); //object of the Car class
      Console.WriteLine(Ford.model);
    }
  }
}
