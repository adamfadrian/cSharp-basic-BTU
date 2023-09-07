using System;

public class GotoTest1
{
  static void Main()
  {
    int x = 200, y = 4;
    int count = 0;
    string[,] Array1 = new string[x, y];
    for (int i = 0; i < x; i++)
      for (int j = 0; j < y; j++)
         Array1[i, j] = (++count).ToString();
    Console.Write("Enter the number to search for: ");
    string MyNumber = Console.ReadLine();
    for (int i = 0; i < x; i++)
    {
      for (int j = 0; j < y; j++)
      {
        if (Array1[i, j].Equals(MyNumber))
            goto Found;
      }
    }
    Console.WriteLine ($"The value {MyNumber} was not found.");
    goto Finish;
  Found:
    Console.WriteLine ($"The value {MyNumber} is found.");
  Finish:
    Console.WriteLine ("End of search.");

    Console.WriteLine ("Press any key to exit.");
    Console.ReadKey();
  }
}