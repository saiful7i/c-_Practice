using System;

namespace Application
//class for car 
{
 class Person
 {
   private string name; // field 
   
   public string Name //property
   { get; set; }   //get-set method to return and assigns value of name
 }
 
 class Program
 {
   static void Main(string[] args)
   {
     Person myObj = new Person();
     myObj.Name = "Liam";
     Console.WriteLine(myObj.Name);
   }
 }
}
