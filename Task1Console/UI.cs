using System;
using Task1;

namespace Task1Console
{
    public static class Ui
    {
        public static void Task1Ui()
        {
            Console.WriteLine("ЗАДАНИЕ 1");
            Console.WriteLine("Поменять в слове первую и последнюю буквы.");
            Console.WriteLine();

            Console.Write("Введите слово: ");
            string word = Console.ReadLine();

            try
            {
                string result = Functions.SwapFirstAndLast(word);

                Console.WriteLine();
                Console.WriteLine("Результат: {0}", result);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: {0}", ex.Message);
            }
        }
    }
}
