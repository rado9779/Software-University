using System;
using System.Text.RegularExpressions;

namespace _03._Post_Office
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split('|');
            string firstPart = line[0];
            string secondPart = line[1];
            string thirdPart = line[2];

            string firstPattern = @"([#$%*&])(?<letters>[A-Z]+)(\1)";
            Match firstMatch = Regex.Match(firstPart, firstPattern);
            string letters = firstMatch.Groups["letters"].Value;

            for (int i = 0; i < letters.Length; i++)
            {
                char firstLetter = letters[i];
                int code = firstLetter;

                string secondPattern = $@"{code}:(?<length>[0-9][0-9])";
                Match secondMatch = Regex.Match(secondPart, secondPattern);
                int length = int.Parse(secondMatch.Groups["length"].Value);

                string thirdPattern = $@"(?<=\s|^){firstLetter}[^\s]{{{length}}}(?=\s|$)";
                Match thirdMatch = Regex.Match(thirdPart, thirdPattern);
                string word = thirdMatch.ToString();

                Console.WriteLine(word);
            }
        }
    }
}
