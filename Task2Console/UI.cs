using System;
using Task2;

namespace Task2Console
{
    public static class Ui
    {
        public static void Task2Ui()
        {
            Console.WriteLine("ЗАДАНИЕ 2");
            Console.WriteLine(
                "Введите от 1 до 30 слов из строчных латинских букв.");
            Console.WriteLine(
                "Длина каждого слова - от 1 до 5 букв.");
            Console.WriteLine(
                "Между словами должна быть запятая, после последнего - точка.");
            Console.WriteLine();
            Console.WriteLine("Пример: cat,dog,cat,bird,dog.");
            Console.WriteLine();

            Console.Write("Введите последовательность: ");
            string sequence = Console.ReadLine();

            try
            {
                string[] result = Functions.FindRepeatedWords(sequence);

                Console.WriteLine();

                if (result.Length == 0)
                {
                    Console.WriteLine(
                        "Слов, встречающихся несколько раз, нет.");
                }
                else
                {
                    Console.WriteLine(
                        "Слова, встречающиеся несколько раз:");

                    for (int i = 0; i < result.Length; i++)
                    {
                        Console.WriteLine(result[i]);
                    }
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: {0}", ex.Message);
            }
        }
    }
}
