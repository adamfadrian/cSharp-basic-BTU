class Basic4
{ // no error, implicit value-conversion
  public static void Main (string[] args)
  {
    object object1 = true;
    object object2 = 1;
    object object3 = 'c';
    object object4 = 1.5;
    object object5 = -0.5f;
    object object6 = 6;
    object object7 = 7L;
    object object8 = (short)8;
    bool object91 = (bool) object1;
    byte object92 = (byte) object2;
    char object93 = (char) object3;
    double object94 = (double) object4;
    float object95 = (float) object5;
    int object96 = (int) object6;
    long object97 = (long) object7;
    short object98 = (short) object8;
  }
}