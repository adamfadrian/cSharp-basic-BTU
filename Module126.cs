class Module126
{
  int operation3()
  {
    int that = 3;
    return (that);  
  }

  void operation5()
  {
    int object5 = operation3();
  }

  static void Main (string[] args)
  {
    Module126 RecordObject1 = new Module126();
    RecordObject1.operation5();
  } 
}   