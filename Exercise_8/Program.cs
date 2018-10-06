using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your name.");
            string name = Console.ReadLine();

            char[] reverse = name.ToCharArray();

            // for(int i = 0; i < reverse.Length; i++)
            // {
            //     Console.WriteLine(reverse.ToString());
            // }  
            Console.Write("You wrote: ");
            foreach(var item in reverse)
            {
                Console.Write(item.ToString());
            }

            Array.Reverse(reverse);

            Console.WriteLine(reverse);
        }
    }
}
//why does it print System.Char[] when I try to add formatting or use ToString?