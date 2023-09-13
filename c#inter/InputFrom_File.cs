using System;
using System.IO;

class InputFrom_File 
{
  static void Main ()
  {    
    try
    {
      FileStream InputFile_Handle = new FileStream
       ("output_test1.data", FileMode.Open);    
      byte an_object = (byte) InputFile_Handle.ReadByte();  
      Console.WriteLine (an_object);
      InputFile_Handle.Close ();    
    }
    catch (Exception error1)
    { Console.WriteLine (error1); }
  }
}