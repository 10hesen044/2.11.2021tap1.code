using System;

namespace _2._11._2021tap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String deyerini girin:");
            string text = Console.ReadLine();
            GetFan(text);
        }
        static void GetFan(string space)
        {
            space = space.Trim();
            for (int i = 0; i < space.Length; i++)
            {
                while (space[i] == ' ' && space[i + 1] == ' ')
                {
                    space = space.Remove(i, 1);
                }

            }
            Console.WriteLine(space);
        }
    }
}
