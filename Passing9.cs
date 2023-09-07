using System;

class Passing9
{ // similar to Passing3
  static void swap (ref NotEmpty operand1, ref NotEmpty operand2)
  {
    NotEmpty temp = new NotEmpty(' ');
    temp = operand1;
    operand1 = operand2;
    operand2 = temp;
  }
  
  static void Main (string[] args)
  {
    NotEmpty Object1 = new NotEmpty('a');
    NotEmpty Object2 = new NotEmpty('b');
    Console.WriteLine ("Values before swapping: " + Object1.column1 + ", " + Object2.column1);
    swap (ref Object1, ref Object2);
    Console.WriteLine ("Values after swapping: " + Object1.column1 + ", " + Object2.column1); 
  }
}
