using System;

public class Compare08
{ // assigning record-value without dynamic allocation

  char column1;

  Compare08 (char operand1)
  {
    column1 = operand1;
  }

  public static void Main (string[] args)
  { // Memory is not dynamically allocated for record-value
    Compare08 Object1 = new Compare08('a'); 
    Compare08 Object2 = Object1; // for Object2
    Compare08 Object3 = new Compare08('a');
    if (Object1.Equals(Object2))
      Console.WriteLine ("Equal record-value");
    else
      Console.WriteLine ("Distinct record-value");
    if (Object1.Equals(Object3))
      Console.WriteLine ("Equal record-value");
    else
      Console.WriteLine ("Distinct record-value");
  }
}