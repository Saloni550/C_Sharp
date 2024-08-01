using System;
namespace MethodOverloading
{
    class program
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
        static void Main(string[] args)
        {
            program program = new program();
            Console.WriteLine("Addition of Number is{0}", program.Add(10, 20));
            Console.WriteLine("Substraction of Number is{0}", program.Sub(50, 20));
            Console.ReadLine();
        }
    }
}