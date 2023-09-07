using System;

public class Branch02
{
  public static void Main (string[] args)
  {
    int object1 = 2;
    switch (object1)
    {
      case 1 : Console.WriteLine ("Value is 1"); break;
      case 2 : Console.WriteLine ("Value is 2"); break;
      default: Console.WriteLine ("Value is neither 1 nor 2"); break;
    }
  }
}