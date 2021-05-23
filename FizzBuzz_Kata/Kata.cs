using System;

namespace FizzBuzz_Kata
{
    public class Kata
    {
        public string FizzBuzz()
        {
            var listData = "";

            for (int i = 0; i <= 100; i++)
            {
                listData += $"{i}" + "\n";
            }

            return listData;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
