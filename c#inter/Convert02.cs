using System;

class Convert02
{ 
  public static void Main (string[] args)
  {
    bool object1 = true;
    byte object2 = 1;
    char object3 = 'c';
    double object4 = 1.5;
    float object5 = -0.5f;
    int object6 = 6;
    long object7 = 7L;
    short object8 = (short)8;
    Console.WriteLine (object1 + " " + object2 + " " + object3 + " " + object4);
    Console.WriteLine (object5 + " " + object6 + " " + object7 + " " + object8);
  }
}