using System;

namespace ITFDN120_Assignment6
{
    class Program
    {
        static bool compare(string one, string two, bool caseInsensitive)
        {
            if (one.Length != two.Length) return false;
            bool match = false;
            for (int i = 0; i < one.Length; i++)
            {
                int first = one[i];
                int second = two[i];
                if (caseInsensitive)
                {
                    if (first == second || first == second - 32 || first == second + 32)
                    {
                        match = true;
                    }
                    else
                    {
                        match = false;
                    }
                }
                else
                {
                    if (first == second)
                    {
                        match = true;
                    }
                    else
                    {
                        match = false;
                    }


                }
            }
            return match;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("compare(hello,hello,false)");
            Console.WriteLine(compare("hello", "hello", false));
            Console.WriteLine("compare(hello,hello,true)");
            Console.WriteLine(compare("hello", "hello", true));
            Console.WriteLine("compare(hello,HELLO,false)");
            Console.WriteLine(compare("hello", "HELLO", false));
            Console.WriteLine("compare(hello,HELLO,true)");
            Console.WriteLine(compare("hello", "HELLO", true));
            Console.ReadLine();
        }
    }
}
