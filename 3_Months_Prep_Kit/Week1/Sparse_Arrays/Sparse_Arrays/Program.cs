
static List<int> matchingStrings(List<string> strings, List<string> queries)
{
    List<int> resultsQuerys = new List<int>();
    bool first = true;

    for (int i = 0; i < queries.Count; i++)
    {
        first = true;
        for (int j = 0; j < strings.Count; j++)
        {
            if (queries[i].Equals(strings[j]))
            {
                if (first)
                {
                    first = false;
                    resultsQuerys.Add(1);
                }

                else
                {
                    resultsQuerys[i] += 1;
                }
            }

         
        }

        if (first)
        {
            resultsQuerys.Add(0);
        }
    }

    //Console.WriteLine(resultsQuerys[3]);
    return resultsQuerys;
}

List<string> strings = new List<string> { "ab", "ab", "abc" };
List<string> queries = new List<string> { "ab", "abc", "bc" };
matchingStrings(strings, queries);