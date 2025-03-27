using System;

namespace Application
{
 class Vehicle //base class(parent)
 {
   public string  brand = "Ford"; //Vehicle class field
   public void honk()             // Vehicle class method
   {
     Console.WriteLine("Tuut, tuut!");
   }
 }
 
 class Car : Vehicle              // Derived Class (child) 
 {
   public string modelName = "Mustang";
 }
 
 class Program
 {
   static void Main(string[] args)
   {
     // Create a myCar object
     Car myCar = new Car();
     
     //Call the honk() method (From the Vehicle class) on the myCar object
     myCar.honk(); //call honk() method
     
     Console.WriteLine(myCar.brand +" "+ myCar.modelName);
   }
 }
}
