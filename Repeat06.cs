using System;

public class Repeat06
{ // about repetition-operation; do while
  public static void Main (string[] args)
  {
    int[] Object1 = new int[] {9, 8, 7, 6, 5};
    int counter = 0, count = Object1.Length;
    do
    {
      Console.Write (Object1[counter]);
      counter++;
    }
    while (counter < count);
    Console.WriteLine ();
  }
}