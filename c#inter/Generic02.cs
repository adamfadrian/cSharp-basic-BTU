using System;
using System.Collections;
using System.Collections.Generic;

public class Generic02
{  
  public static void Main (string[] args)
  {
    List<object> CollectionObject1 = new List<object>();  
    CollectionObject1.Add (true);  
    CollectionObject1.Add ('a');  
    CollectionObject1.Add (0.25);  
    CollectionObject1.Add (-123);  
    Console.WriteLine ("Item at subscript 2: " + CollectionObject1[2]);  
    foreach (var an_object in  CollectionObject1)
      Console.WriteLine (an_object);  
  }  
}