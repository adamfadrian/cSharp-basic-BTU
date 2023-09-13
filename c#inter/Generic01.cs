public class Generic01
{
  public static void Main (string[] args)
  {
    bool object1 = true;
    byte object2 = 1;
    char object3 = 'c';
    double object4 = 1.5;
    float object5 = -0.5f;
    int object6 = 6;
    long object7 = 7L;
    short object8 = (short)8;
    object[] ArrayObject1 = new object[8];
    ArrayObject1[0] = object1;
    ArrayObject1[1] = object2;
    ArrayObject1[2] = object3;
    ArrayObject1[3] = object4;
    ArrayObject1[4] = object5;
    ArrayObject1[5] = object6;
    ArrayObject1[6] = object7;
    ArrayObject1[7] = object8;
  }
}