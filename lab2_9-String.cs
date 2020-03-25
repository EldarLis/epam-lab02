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
            string str;
            string[] words;

            var path = @"output.txt";
            StringBuilder res = new StringBuilder();

            File.WriteAllText(path, "");

            if (c == 'f')
            {
                StreamReader input = new StreamReader("input.ini");
                string line = input.ReadLine();
                while (line != null)
                {
                    words = line.Split(' ');
                    for(int counter = 1; counter < words.Length; counter+= 2)
                    {
                        res.Append(words[counter] + " ");
                    }
                    File.AppendAllText(path, "\n" + res.ToString());
                    res.Clear();
                    line = input.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Write lines all you want. Empty line to end");
                string line = Console.ReadLine();
                while (line != "")
                {
                    words = line.Split(' ');
                    for (int counter = 1; counter < words.Length; counter += 2)
                    {
                        res.Append(words[counter] + " ");
                    }
                    File.AppendAllText(path, "\n" + res.ToString());
                    res.Clear();
                    line = Console.ReadLine();
                }
            }

        }
    }
}
