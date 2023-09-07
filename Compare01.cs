using System;

public class Compare01
{
  public static void Main (string[] args)
  {
    bool object1 = 0 == 0;
    bool object2 = 0 != 0;
    bool object3 = 1 < 0;
    bool object4 = 1 <= 0;
    bool object5 = 1 > 0;
    bool object6 = 1 >= 0; 
    Console.WriteLine (object1 + ", " + object2 + ", " + object3);
    Console.WriteLine (object4 + ", " + object5 + ", " + object6);
  }
}