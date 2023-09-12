using System;


// Buat C# program dengan 1 user-defined module. Let's say you write Y0. 
// Record-type Y0 is non-nullary. One column is nesting collection of char.
// Write path-expression involving nested item within the record.
class Y0
{   
    //  column with collection of char
    char[] column1;
    public Y0(char[] operand)
    {
        this.column1 = operand;
    }
    public char[] GetColumn1()
    {
        return column1;
    }
    static void Main()
    {
        char[] Obj = { 'H', 'e', 'l', 'l', 'o', ' ' };
        Y0 RecordObject = new Y0(Obj);
        // RecordObject.column1;
        char[] NestedItems = RecordObject.GetColumn1();
        Console.WriteLine(NestedItems);
    }
}



// class Collection
// {
//     char[][] column1;

//     Collection(char[][] operand)
//     {
//         this.column1 = operand;
//     }


//     public static void Main()
//     {
//         Collection object1 = new Collection()
//     }
// }

