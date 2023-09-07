public class Assign02
{ // assigning collection-value without dynamic allocation
  public static void Main (string[] args)
  { // Memory is not dynamically allocated for integer-collection value
    string Object1 = "A string value";
    string Object2 = Object1; // for Object2
    string Object3 = "A string value";
  }
}