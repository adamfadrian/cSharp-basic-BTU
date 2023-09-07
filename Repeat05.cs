using System;

public class Repeat05
{ // about repetition-operation; for
  public static void Main (string[] args)
  {
    int[] Object1 = new int[] {9, 8, 7, 6, 5};
    int counter = 0, count = Object1.Length;
    while (counter < count)
    {
      Console.Write (Object1[counter]);
      counter = counter + 1;
    }
    Console.WriteLine ();
  }
}