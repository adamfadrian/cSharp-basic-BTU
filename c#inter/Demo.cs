using System;

class Demo : abc
{
  public static void Main()
  {
    System.Console.WriteLine("Hello Interfaces");
    Demo RecordObject1 = new Demo();
    RecordObject1.xyz();
  }

  public void xyz()
  {
     System.Console.WriteLine("In xyz");
  }  
}