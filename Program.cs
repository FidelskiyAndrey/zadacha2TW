using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Объявляем переменную textBase вводимыми с клавиатуры значениями.

            string textBase = Console.ReadLine();

            //Удаляем пробелы и в случае если был верхний регистр приводим его к нижнему регистру

            textBase = textBase.Replace(" ", "").Replace(".", "").ToLower();

            //Создаем массив символов из переменной строкового типа, чтобы использовать на ней метод (Array.Reverse)


            char[] char1 = textBase.ToCharArray();

            Array.Reverse(char1);

            //Создаем переменную textFinal с отзеркаленными символами

            string textFinal = new string(char1);

            //С помощью оператора if сравниваем исходный текст с отзеркаленным

            if (textBase == textFinal)
            {
                Console.WriteLine("Фраза является палиндромом");
            }
            else
            {
                Console.WriteLine("Фраза не является палиндромом");
            }

            Console.ReadKey();


        }
    }
}
