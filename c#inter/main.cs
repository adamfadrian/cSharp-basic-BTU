namespace Namespace2
{
  class Module001
  {
    public void operation001()
    {
      System.Console.WriteLine ("operation001 inside Namespace2");
    }
  }

  // Create a nested namespace, and define another class.
  namespace NestedNamespace
  {
    class  Module001
    {
      public void operation001()
      {
        System.Console.WriteLine ("operation001 inside NestedNamespace");
      }
    }
  }

  class main
  {
    static void Main (string[] args)
    {
      Module001 outer = new  Module001();
      outer.operation001(); // Displays "operation001 inside Namespace2."

      Namespace2.Module001 outer2 = new Namespace2.Module001();
      outer2.operation001();  // Displays "operation001 inside Namespace2."

      NestedNamespace.Module001 inner = new NestedNamespace.Module001();
      inner.operation001();   // Displays "operation001 inside NestedNamespace."
    }
  }
}