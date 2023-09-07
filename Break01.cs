using System;

public class Break01
{
  public static void Main (string[] args)
  {
    int object1 = 2;
    switch (object1)
    {
      case 1 : Console.WriteLine ("Value is 1");
      case 2 : Console.WriteLine ("Value is 2");
      default: Console.WriteLine ("Value is neither 1 nor 2");
    }
  }
}