using System;

public class Compare03
{ // assigning collection-value without dynamic allocation
  public static void Main (string[] args)
  { // Memory is not dynamically allocated for integer-collection value
    int[] Object1 = new int[] {1, 2};
    int[] Object2 = Object1; // for Object2
    int[] Object3 = new int[] {1, 2};
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