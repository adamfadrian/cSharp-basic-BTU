// Untuk Adam. 
// Lengkapi program ini agar berisi user-defined operation yang operate collection of binary-records.

using System;
class Challenge5
{
  char x, y;
  Challenge5(char x, char y)
  { // change the header
    this.x = x;
    this.y = y;
  } // fill the operation-body

  static void Operation1 (Challenge5[] y)
  {
  }

  static void Operation2 (Challenge5 y)
  {
  }
  
  public static void Main(string[] args)
  {
    Challenge5 RecordObject1 = new Challenge5('f', 's');
    Challenge5 RecordObject2 = new Challenge5('S', 's');
    Challenge5 RecordObject3 = new Challenge5('T', 's');
    Challenge5[] CollectionObject = new Challenge5[] { RecordObject1, RecordObject2, RecordObject3 };
    Operation1 (CollectionObject);
    Operation2 (CollectionObject[0]);
    Console.WriteLine(CollectionObject);
    Console.WriteLine(CollectionObject[0]);
    int[] Z = {1 , 2}; // type-of-expression Z is integer[]
    int a = Z[0] * 3;   // type-of-expression Z[0] is integer
  } // type-of-expression CollectionObject is Challenge5[]
}   // type-of-expression CollectionObject[0] is Challenge5

Concept0 A = new Concept0 ('a');

char z = A.column1;                 // record-object
char y = new Concept0('b').column1; // record-value
char x = function1().column1;       // record-operation-call