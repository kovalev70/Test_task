using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("(С регулярными выражениями)" +
            "\nВведите строку:");
        string? input = Console.ReadLine();

        string linkPattern = @"((https?|ftp):\/\/)?[\w-]+(\.[\w-]+)+\S*";

        string emailPattern = @"[a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9_-]+";

        string result = Regex.Replace(input, linkPattern + "|" + emailPattern,
            match => new string('*', match.Length));

        Console.WriteLine($"Результат замены: \n{result}");


        Console.WriteLine("(Без регулярных выражений)" +
            "\nВведите строку:");
        input = Console.ReadLine();

        string[] words = input.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (IsLink(words[i]) || IsEmail(words[i]))
            {
                words[i] = new string('*', words[i].Length);
            }
        }

        result = string.Join(" ", words);
        Console.WriteLine($"Результат замены: \n{result}");
    }

    static bool IsLink(string word)
    {
        return word.StartsWith("www.")
            || word.StartsWith("http://")
            || word.StartsWith("https://")
            || word.Contains('.') 
            || word.Contains('/');
    }

    static bool IsEmail(string word)
    {
        return word.Contains("@");
    }
}