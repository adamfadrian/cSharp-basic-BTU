using System;

class Module138
{
  int object1;

  Module138 (int operand1)
  {
    this.object1 = operand1;
  }

  void operation1 ()
  {
    Module138 RecordObject1 = new Module138 (1);
    Console.WriteLine (RecordObject1.object1);
  }
}