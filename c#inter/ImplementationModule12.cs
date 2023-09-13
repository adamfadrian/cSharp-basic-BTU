using System;

class ImplementationModule12 
 : InterfaceModule11
{
  public void operation04()
  {
    Console.WriteLine ("public static operation04");
  }

  static void Main()
  {
    ImplementationModule12 RecordObject1 = 
     new ImplementationModule12();
    RecordObject1.operation04();
  }
}