using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово");

            string word = Console.ReadLine();
            bool isValid = word.All(Char.IsLetter);
            if (isValid == false)
            {
                Console.WriteLine("Нужно ввести одно слово из букв");
            }
            else
            {
                if (IsPalindrom(word) == true)
                {
                    Console.WriteLine("Палиндром");
                }
                else
                {
                    Console.WriteLine("Не палиндром");
                }

                Console.ReadLine();
            }
        }
        public static bool IsPalindrom(string word)
        {
            bool r = true;
            for (int i = 0; i < word.Length - 1; i++)
            {
                int n = word.Length - 1 - i;

                if (word[i] != word[n])
                {
                    r = false;
                }
            }
            return r;
        }
    }
}

