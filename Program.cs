using System;
using static program;
class program
{
    public delegate void voidDelgate();
    public static void Main(string[]args)
    {
        voidDelgate dell = Print1;
        myclass.ExecuteDelegate(dell);
    }
    private static void Print1()
    {
        Console.WriteLine("Method 1");
    }
}
class myclass
{
    public static void ExecuteDelegate(voidDelgate del)
    {
        del();
    }
}*/

