﻿using System;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0;
            string word = "";
            Console.WriteLine("Вводите слова, завершающая каждое нажатие Enter.");
            Console.WriteLine("Для выхода наберите exit");
            for (; ; )
            {
                string temp = Console.ReadLine();
                if (temp == "exit")
                    break;
                if (m < temp.Length)
                {
                    m = temp.Length;
                    word = temp;
                }
            }
            Console.WriteLine("Считывание завершено.");
            Console.WriteLine("Самое длинное слово: " + word.ToUpper() + " (" + m + ")");
        }
    }
}