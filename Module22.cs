using System;

class Module22
{
  int column1;
  
  private static void operation2 ()
  {
    Console.WriteLine (this.column1);    
  }

  public static void Main (string[] args)
  {
    operation2();
  }
}