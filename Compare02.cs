using System;

public class Compare02
{ // assigning record-value without dynamic allocation
  public Compare02 ()
  {
  }

  public static void Main (string[] args)
  { // Memory is not dynamically allocated for record-value
    Compare02 Object1 = new Compare02(); 
    Compare02 Object2 = Object1; // for Object2
    Compare02 Object3 = new Compare02();
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