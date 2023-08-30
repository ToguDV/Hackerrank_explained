
static List<int> matchingStrings(List<string> strings, List<string> queries)
{
    List<int> resultsQuerys = new List<int>();


    for (int i = 0; i < queries.Count; i++)
    {
        resultsQuerys.Add(0);
        for (int j = 0; j < strings.Count; j++)
        {
            if (queries[i].Equals(strings[j]))
            {
                resultsQuerys[i] += 1;
            }
        }
    }

    Console.WriteLine(resultsQuerys[0]);
    return resultsQuerys;
}

List<string> strings = new List<string> { "ab", "ab", "abc" };
List<string> queries = new List<string> { "ab", "abc", "bc" };
matchingStrings(strings, queries);