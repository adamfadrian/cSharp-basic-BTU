public class Assign00
{ // assigning record-value without dynamic allocation
  public static void Main (string[] args)
  { // Memory is not dynamically allocated for record-value
    Assign00 Object1 = new Assign00(); 
    Assign00 Object2 = Object1; // for Object2
    Assign00 Object3 = new Assign00();
  }
}