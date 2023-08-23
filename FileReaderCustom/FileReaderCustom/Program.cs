using FileReaderCustom;

string filePath = "./Files/txt.txt"; // Замініть на шлях до вашого текстового файлу
int validPasswordsCount = 0;

foreach (string line in File.ReadLines(filePath))
{
    if (RegexChecker.IsValidPassword(line))
    {
        validPasswordsCount++;
    }
}

Console.WriteLine($"Number of valid passwords: {validPasswordsCount}");