using System;

public class Compare09
{ // assigning record-value without dynamic allocation
  char column1;

  Compare09 (char operand1)
  {
    column1 = operand1;
  }

  static bool equals (int[] A, int[] B)
  {
    if (A.Length != B.Length)
      return (false);
    short counter, count = (short) A.Length;
    for (counter = 0; counter < count; counter++)
      if (A[counter] != B[counter])
        return (false);
    return (true);
  }
  
  public static void Main (string[] args)
  { // Memory is not dynamically allocated for record-value
    int[] Object1 = new int[] {1, 2};
    int[] Object2 = new int[] {1, 2};
    Compare09 Object3 = new Compare09('a'); 
    Compare09 Object4 = new Compare09('a');
    Console.WriteLine (equals(Object1, Object2));
    if (Object3.column1 == Object4.column1)
      Console.WriteLine ("Equal record-value");
    else
      Console.WriteLine ("Distinct record-value");
  }
}