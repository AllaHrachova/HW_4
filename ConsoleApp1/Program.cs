using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово");
            string newWord = Console.ReadLine();
            bool isValid = newWord.All(Char.IsLetter);
            if (!isValid)
            {
                Console.WriteLine("Нужно ввести одно слово из букв");
            }
            else
            {
                string result = IsPalindrom(newWord) ? "Палиндром" : "Не палиндром";
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }

        public static bool IsPalindrom(string word)
        {
            bool palindrom = true;
            for (int i = 0; i < word.Length - 1; i++)
            {
                int length = word.Length - 1 - i;

                if (word[i] != word[length])
                {
                    palindrom = false;
                }
            }
            return palindrom;
        }
    }
}