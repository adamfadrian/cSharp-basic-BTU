using System;

class Module140
{
  int column1;

  Module140 (int operand1)
  {
    column1 = operand1;
  }

  void operation1 ()
  {
    Console.WriteLine (column1);
  }

  public static void Main (string[] args)
  {
    Module140 RecordObject1 = new Module140(1);
    Module140 RecordObject2 = new Module140(2);
    RecordObject1.operation1();
    RecordObject2.operation1();
  }
}