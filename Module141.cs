using System;

class Module141
{
  int column1;

  Module141 (int operand1)
  {
    this.column1 = operand1;
  }

  void operation1 ()
  {
    Console.WriteLine (this.column1);
  }

  public static void Main (string[] args)
  {
    Module141 RecordObject1 = new Module141(1);
    Module141 RecordObject2 = new Module141(2);
    RecordObject1.operation1();
    RecordObject2.operation1();
  }
}