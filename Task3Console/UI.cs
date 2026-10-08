using System;
using Task3;

namespace Task3Console
{
    public static class Ui
    {
        public static void Task3Ui()
        {
            Console.WriteLine("ЗАДАНИЕ 3");
            Console.WriteLine("Удалить из данного слова все гласные буквы.");
            Console.WriteLine();

            Console.Write("Введите слово: ");
            string word = Console.ReadLine();

            try
            {
                string result = Functions.RemoveVowels(word);

                Console.WriteLine();

                if (result.Length == 0)
                {
                    Console.WriteLine(
                        "После удаления гласных получилась пустая строка.");
                }
                else
                {
                    Console.WriteLine("Результат: {0}", result);
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
