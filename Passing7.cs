using System;

class Passing7
{ // similar to Passing0
  public static void swap (ref char operand1, ref char operand2)
  {
    char temp = operand1;
    operand1 = operand2;
    operand2 = temp;
  }
  
  public static void Main (string[] args)
  {
    char object1 = 'a';
    char object2 = 'b';
    Console.WriteLine ("Values before swapping: " + object1 + ", " + object2);
    swap (ref object1, ref object2);
    Console.WriteLine("Values after swapping: " + object1 + ", " + object2); 
  }
}
