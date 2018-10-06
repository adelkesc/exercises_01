using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var add = new Calculator(2, 2);
            var addArray = new Calculator(new int[] {1, 2, 3, 4, 5});  //this should equal 15

            Console.WriteLine(addArray.Add(new int[] {1, 2, 3, 4, 5}));
            Console.WriteLine(add.Add(2, 2));
        }
    }
}
