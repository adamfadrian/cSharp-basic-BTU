class Module129
{
  int operation3()
  {
    int that = 3;
    return (that);  
  }

  static int operation4()
  {
    Module129 RecordObject1 = new Module129();
    int object5 = RecordObject1.operation3();
    return (object5);
  }

  static void Main (string[] args)
  {
    operation4();
  } 
}   