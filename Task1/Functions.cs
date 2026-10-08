using System;

namespace Task1
{
    public static class Functions
    {
        public static string SwapFirstAndLast(string word)
        {
            ValidateWord(word);

            if (word.Length == 1)
                return word;

            char[] chars = word.ToCharArray();

            char temp = chars[0];
            chars[0] = chars[chars.Length - 1];
            chars[chars.Length - 1] = temp;

            return new string(chars);
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
