using System;

// class ParentRecord
// {
//     class ChildRecord
//     {
//         public static void Test()
//         {
//             Console.WriteLine("Record of Record");
//         }
//     }
//     public static void Main()
//     {
//         Console.WriteLine("From ParentRecord");
//         ChildRecord.Test();
//     }
// }



// class Complex
// {
//     int[][] jaggedArray;
//     public Complex()
//     {
//         jaggedArray = new int[3][];
//         jaggedArray[0] = new int[] { 1, 2, 3 };
//         jaggedArray[1] = new int[] { 4, 5 };
//         jaggedArray[2] = new int[] { 6, 7, 8, 9 };
//     }

// }

class Complex
{
    char column;
    Complex(char operand)
    {
        this.column = operand;
    }

    void operation()
    {

    }
    public static void Main()
    {
        Complex RecordObject = new Complex('a');
        Complex RecordObject2 = new Complex('b');
    }
}

class Collection11
{
    static char[] operation0()
    {
        return ("Hello".ToCharArray());
    }
    static int[] operation1()
    {
        return (new int[] { -2, 1, 0, 2, 1 });
    }
    static void Main()
    { // ignore the returned-values
        operation0(); // does NOT raise error
        operation1();
    }
}


class Complex
{
    static void main()
    {
        Complex[] RecordObject = new Complex[2] { 1, 2 }
    }
}