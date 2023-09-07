using System;

public class Assign03
{ // assigning record-value without dynamic allocation
  char column1;

  Assign03 (char initial_value)
  { this.column1 = initial_value; }

  public static void Main (string[] args)
  { // Memory is not dynamically allocated for record-value
    Assign03 Object1 = new Assign03('a'); 
    Assign03 Object2 = Object1; // for Object2
    Assign03 Object3 = new Assign03('a');
    if (Object1 == Object2)
      Console.WriteLine ("Equal record-value");
    else
      Console.WriteLine ("Distinct record-value");
    if (Object1 == Object3)
      Console.WriteLine ("Equal record-value");
    else
      Console.WriteLine ("Distinct record-value");
  }
}