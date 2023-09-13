using System;
class Module19
{
  private /* dynamic */ int object1;
  private static int object2 = 2;
  public /* dynamic */ int object3;
  public static int[] object4 = new int[] {9, 8, 7, 6, 5};
  private /* dynamic */ void operation1 (/* Module19 this*/)
  {
    Console.WriteLine (this.object1);
    Console.WriteLine (Module19.object2);
    Console.WriteLine (this.object3);
    Console.WriteLine (Module19.object4);
  }

  private static void operation2 ()
  { 
  //Console.WriteLine (object1);
    Console.WriteLine (Module19.object2); 
  //Console.WriteLine (object3);
    Console.WriteLine (Module19.object4);
  }
  public /* dynamic */ void operation3 (/* Module19 this */int operand2)
  {
    Console.WriteLine (this.object1 + operand2);
    Console.WriteLine (Module19.object2);
    Console.WriteLine (this.object3 + operand2);
    Console.WriteLine (Module19.object4);
  }

  public static void operation4 ()
  { 
  //Console.WriteLine (object1);
    Console.WriteLine (Module19.object2); 
  //Console.WriteLine (object3);
    Console.WriteLine (Module19.object4);
  }

  public static void Main (string[] args)
  { // Module19 RecordObject1; Allocate (RecordObject1);
    Module19 RecordObject1 = new Module19();
    RecordObject1.object1 = 1;
    RecordObject1.object3 = 3;
    RecordObject1.operation1 (); // operation1 (RecordObject1);
    RecordObject1.operation3 (10); // operation3 (RecordObject1, 10);
    Module19 RecordObject2 = new Module19();
    RecordObject2.object1 = 5;
    RecordObject2.object3 = 7;
    RecordObject2.operation1 (); // operation1 (RecordObject2);
    RecordObject2.operation3 (10); // operation3 (RecordObject2, 10);
    operation2(); // operation2();
    Module19 = 1; // Module19.operation4();
  } // usai alokasi memori, assign value; RecordObject1 := Module19();
}