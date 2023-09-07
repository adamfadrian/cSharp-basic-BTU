class Module127
{
  static int operation4()
  {
    int that = 3;
    return (that);  
  }

  void operation5()
  {
    int object5 = operation4();
  }

  static void Main (string[] args)
  {
    Module127 RecordObject1 = new Module127();
    RecordObject1.operation5();
  } 
}