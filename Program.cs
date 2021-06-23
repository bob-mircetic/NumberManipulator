using System;

namespace numbermanipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            input = input * input;

            input += 14;

            input -= 3;

            Console.WriteLine(input);
            
        }
    }
}
