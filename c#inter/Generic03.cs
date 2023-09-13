using System;

public class Generic03
{ 
  static void Insert (object[] Operand1, object operand2, int subscript)
  {
    Operand1[subscript] = operand2;
  }
  
  public static void Main (string[] args)
  {
    object object1 = true;
    object object2 = 1;
    object object3 = 'c';
    object object4 = 1.5;
    object object5 = -0.5f;
    object object6 = 6;
    object object7 = 7L;
    object object8 = (short)8;
    object[] ArrayObject1 = new object[8];
    Insert (ArrayObject1, object1, 0);
    Insert (ArrayObject1, object2, 1);
    Insert (ArrayObject1, object3, 2);
    Insert (ArrayObject1, object4, 3);
    Insert (ArrayObject1, object5, 4);
    Insert (ArrayObject1, object6, 5);
    Insert (ArrayObject1, object7, 6);
    Insert (ArrayObject1, object8, 7);
    for (int counter = 0; counter < ArrayObject1.Length; counter++)
      Console.WriteLine (ArrayObject1[counter]);
  }
}