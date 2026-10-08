using System;

namespace Task3
{
    public static class Functions
    {
        public static string RemoveVowels(string word)
        {
            ValidateWord(word);

            const string vowels = "aeiouAEIOU";

            char[] result = new char[word.Length];
            int resultLength = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.IndexOf(word[i]) == -1)
                {
                    result[resultLength] = word[i];
                    resultLength++;
                }
            }

            return new string(result, 0, resultLength);
        }

        private static void ValidateWord(string word)
        {
            if (word == null)
                throw new ArgumentNullException(
                    "word",
                    "Слово не задано.");

            if (word.Length == 0)
                throw new ArgumentException(
                    "Слово не должно быть пустым.");

            if (string.IsNullOrWhiteSpace(word))
                throw new ArgumentException(
                    "Слово не должно состоять из пробелов.");

            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];

                bool isLowerLatin = c >= 'a' && c <= 'z';
                bool isUpperLatin = c >= 'A' && c <= 'Z';

                if (!isLowerLatin && !isUpperLatin)
                    throw new ArgumentException(
                        "Слово должно содержать только латинские буквы.");
            }
        }
    }
}
