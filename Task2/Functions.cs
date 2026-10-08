using System;
using System.Collections.Generic;

namespace Task2
{
    public static class Functions
    {
        public static string[] FindRepeatedWords(string sequence)
        {
            if (sequence == null)
                throw new ArgumentNullException(
                    "sequence",
                    "Последовательность не задана.");

            if (sequence.Length == 0)
                throw new ArgumentException(
                    "Последовательность не должна быть пустой.");

            if (string.IsNullOrWhiteSpace(sequence))
                throw new ArgumentException(
                    "Последовательность не должна состоять из пробелов.");

            if (sequence[sequence.Length - 1] != '.')
                throw new ArgumentException(
                    "После последнего слова должна стоять точка.");

            string text = sequence.Substring(0, sequence.Length - 1);

            if (text.Length == 0)
                throw new ArgumentException(
                    "Последовательность должна содержать хотя бы одно слово.");

            if (text.Contains("."))
                throw new ArgumentException(
                    "Точка допускается только после последнего слова.");

            string[] words = text.Split(',');

            if (words.Length < 1 || words.Length > 30)
                throw new ArgumentException(
                    "Количество слов должно быть от 1 до 30.");

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 0)
                    throw new ArgumentException(
                        "Между запятыми должно находиться слово.");

                if (words[i].Length < 1 || words[i].Length > 5)
                    throw new ArgumentException(
                        "Каждое слово должно содержать от 1 до 5 букв.");

                for (int j = 0; j < words[i].Length; j++)
                {
                    char c = words[i][j];

                    if (c < 'a' || c > 'z')
                        throw new ArgumentException(
                            "Слова должны содержать только строчные латинские буквы.");
                }
            }

            List<string> result = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < words.Length; j++)
                {
                    if (words[i] == words[j])
                        count++;
                }

                if (count > 1 && !result.Contains(words[i]))
                    result.Add(words[i]);
            }

            return result.ToArray();
        }
    }
}
