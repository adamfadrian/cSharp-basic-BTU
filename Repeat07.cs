using System;

public class Repeat07
{ // about repetition-operation; for
  public static void Main (string[] args)
  {
    int[] Object1 = new int[] {9, 8, 7, 6, 5};
    int counter, count = Object1.Length;
    for (counter = 0; counter < count; counter++)
      Console.Write (Object1[counter]);
    Console.WriteLine ("");
  }
}