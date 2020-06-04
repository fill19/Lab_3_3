using System;
using System.IO;
namespace Lab_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText("input.txt");
            foreach (string s in "0 1 2 3 4 5 6 7 8 9".Split(' '))
            {
                text = text.Replace(s, "");
            }
            System.IO.File.WriteAllText("output.txt", text);

            Console.ReadKey();
        }
    }
}
