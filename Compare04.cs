using System;

public class Compare04
{ // assigning collection-value without dynamic allocation
  public static void Main (string[] args)
  { // Memory is not dynamically allocated for integer-collection value
    String Object1 = "A string value";
    String Object2 = Object1; // for Object2
    String Object3 = "A string value";
    if (Object1 == Object2)
      Console.WriteLine ("Equal collection-value");
    else
      Console.WriteLine ("Distinct collection-value");
    if (Object1 == Object3)
      Console.WriteLine ("Equal collection-value");
    else
      Console.WriteLine ("Distinct collection-value");
  }
}