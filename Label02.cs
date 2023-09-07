using System;

public class Label02
{
  public static void Main (string[] args) 
  {
    short i, j;
  level2:
    for (i = 0; i < 5; i++)    // repetition level 2
    { 
      Console.WriteLine("i == " + i);
    level1:
      for (j = 0; j < 5; j++)    // repetition level 1
      {
        if (i == j) 
          goto level1;     // same as break(1);
        else if (i == 4 && j == 3)
          goto level2;
        Console.WriteLine(" j == " + j);
      }
    }
  }
}