class Module144
{
 private int column2;
 Module144 (int operand2)
 {
 this.column2 = operand2;
 }
 private int operation2 ()
 {
 return (this.column2);
 }
 public void operation1 ()
 {
 this.operation2 ();
 }
 static void Main (string[] args)
 {
 Module144 X = new Module144 (6);
 X.operation1 ();
 }
}
// User-defined public operation1 calling private operation2