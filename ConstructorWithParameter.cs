using System;

namespace Program
//class for car 
{
  class Car
  {
    public string model;  //field of class
    public string color;
    public int year;
  
    public Car(string modelName, string modelColor,int modelYear) //Car class Constructor with Parameter
    {
      model = modelName; //initial value of model
      color = modelColor;
      year = modelYear;
    }
    
    static void Main(string[] args)
    {
      Car Ford = new Car("Mustang","RED",1996); //object of the Car class
      Console.WriteLine(Ford.color + " " +Ford.year+" "+Ford.model);
    }
  }
}
