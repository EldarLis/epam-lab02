using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.WriteLine("f - for file; enything else for hands");
            c = char.Parse(Console.ReadLine());
            int N;
            string[] str;
            if (c == 'f')
            {
                StreamReader input = new StreamReader("input.ini");
                N = int.Parse(input.ReadLine().Trim());
                str = input.ReadLine().Trim().Split(' ');
            }
            else
            {
                Console.WriteLine("input number of values");
                N = int.Parse(Console.ReadLine());
                Console.WriteLine("Input all numbers of array");
                str = Console.ReadLine().Trim().Split(' ');
            }
            StringBuilder res = new StringBuilder();
            int prev = 1, curr = 1;
            for(; curr < N; )
            {
                res.Append(str[curr-1] + " ");
                curr += prev;
                prev = curr - prev;
            }

            var path = @"output.txt";
            string result = res.ToString();
            File.WriteAllText(path, result);
        }
    }
}
