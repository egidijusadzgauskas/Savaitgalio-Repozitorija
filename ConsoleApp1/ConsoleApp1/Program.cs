using System;
using System.Collections.Generic;
namespace gitHub_mokymai
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = new string[26];
            for (var i = 0; i < 26; i++)
                strings[i] = $"\"{(char)('a' + i)}\"";
            Console.WriteLine($"「{string.Join(",", strings)}」");
            for (int i = 0; i < 100; i++)
            {
                Console.Write("Egidijus");
            }
        }
    }
}
