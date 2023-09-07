using System;

class Passing8
{ // similar to Passing0
  static void swap (ref string operand1, ref string operand2)
  {
    string temp = operand1;
    operand1 = operand2;
    operand2 = temp;
  }
  
  static void Main (string[] args)
  {
    string object1 = "Hello ";
    string object2 = "world.";
    Console.WriteLine ("Values before swapping: " + object1 + ", " + object2);
    swap (ref object1, ref object2);
    Console.WriteLine ("Values after swapping: " + object1 + ", " + object2); 
  }
}
