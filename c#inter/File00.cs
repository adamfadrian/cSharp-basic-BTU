// Uni-file having multi source-code module.
using System;

  class Module023
  {
    public void operation02()
    {
      Console.WriteLine ("This is a line from operation01.");
    }
  }

  public class Module024
  {
    static void Main ()
    {
      Module023 RecordObject1 = new Module023();
      RecordObject1.operation02 ();
    }
  }
