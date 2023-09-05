static string pangrams(string s)
{
    HashSet<char> letters = new HashSet<char>();

    foreach (char c in s.ToLower())
    {
        if (Char.IsLetter(c))
        {
            letters.Add(c);
        }
    }

    return letters.Count == 26 ? "pangram" : "not pangram";
}


Console.WriteLine(pangrams("We promptly judged antique ivory buckles for the prize"));
