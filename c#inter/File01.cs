// Making sample .NET library.
using System;

namespace Library01
{
  public class Module002
  {
    public void operation02()
    {
      Console.WriteLine ("This is a line from operation01.");
    }
  }

  public class Module003
  {
    public void operation03()
    {
      Module002 RecordObject1 = new Module002();
      RecordObject1.operation02 ();
    }
  }
}
