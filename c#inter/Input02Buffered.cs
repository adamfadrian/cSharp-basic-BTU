using System; 
using System.IO; 
  
class Input02Buffered 
{ 
  static void Main() 
  { 
    try 
    {
      StreamReader StreamReader1 = new StreamReader("output_test2.data");
        string line; 
        while ((line = StreamReader1.ReadLine()) != null) 
          Console.WriteLine(line); 
    }
    catch (Exception error1) 
    { // let the user know what went wrong. 
      Console.WriteLine ("The fi1e cou1d not be read:"); 
      Console.WriteLine (error1.Message); 
    }  
  } 
}