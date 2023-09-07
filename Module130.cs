class Module130
{ // improper initialization
  int column1;

  Module130 ()
  {
  }

  void operation1 ()
  {
    Module130 RecordObject1 = new Module130();
    Module130 RecordObject2 = new Module130();
    RecordObject1.column1 = 1;
    RecordObject1.column1 = 2;
  }
}