namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 8, 10, 3, 4, 6 };
            Console.WriteLine(Min(numbers));
            Console.WriteLine(CapitalLetters("Hello World Salam"));
            Console.WriteLine(TrimmedWord("   Ilham Abbasov  "));

        }

        static int Min(int[] numbers)
        {
            int minNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (minNumber > numbers[i])
                {
                    minNumber = numbers[i];
                }
            }

            return minNumber;
        }

        static string CapitalLetters(string word)
        {
            string capitalLetters = "";
            capitalLetters += word[0];

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    capitalLetters += word[i + 1];
                
                }
            }

            return capitalLetters;
        }

        static string TrimmedWord(string word)
        {
            string trimmedWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ')
                {
                    trimmedWord += word[i];
                }

            }
            return trimmedWord;
        }
    }
}
