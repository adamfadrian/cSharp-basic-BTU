using System;

public class Convert01
{
  public static void Main (string[] args)
  {
    byte object1 = 127;
    char object2 = (char) object1;
    double object3 = 1.0;
    int object5 = (int) object3;
    Console.WriteLine (object2 + " " + object5);
  }
}