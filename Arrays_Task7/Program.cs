class Program
{
    public static void Main()
    {
        string guardPhrase = GetPhraseFromFile(); 
        char[] separators = new char[] { ' ', '.',',', '!','-'};
        string[] guardPhraseArray = guardPhrase.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        
        foreach (var phrase in guardPhraseArray)
        {
            Console.WriteLine(phrase);
        }
    }

    public static string GetPhraseFromFile()
    {
        string[] lines = File.ReadAllLines("TESOblivionGuardsPhrases.txt");
        Random rnd = new Random();
        string phrase = lines[rnd.Next(lines.Length)];
        Console.WriteLine(phrase);
        return phrase;
    }
}