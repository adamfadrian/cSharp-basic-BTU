using System;

public class Continue1
{ // about branching-operation; break
  public static void Main (string[] args)
  {
    int[] Object1 = new int[] {9, 8, 7, 6, 5};
    int counter, count = Object1.Length;
    for (counter = 0; counter < count; counter++)
      if (counter == 2)
        continue;
      else
        Console.Write (Object1[counter]);
    Console.WriteLine (counter);
  }
}