using System.Text.RegularExpressions;

namespace FileReaderCustom
{
    public static class RegexChecker
    {
        public static bool IsValidPassword(string input)
        {
            Match match = Regex.Match(input, @"([a-z]) (\d+)(?:-(\d+))?: ([a-z]+)");
            if (match.Success)
            {
                char requiredChar = match.Groups[1].Value[0];
                int minCount = int.Parse(match.Groups[2].Value);
                int maxCount = match.Groups[3].Success ? int.Parse(match.Groups[3].Value) : minCount;
                string password = match.Groups[4].Value;

                int charCount = password.Split(requiredChar).Length - 1;
                return charCount >= minCount && charCount <= maxCount;
            }

            return false;
        }
    }
}
