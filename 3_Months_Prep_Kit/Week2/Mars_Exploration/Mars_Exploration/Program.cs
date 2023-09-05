static int marsExploration(string s)
{
    int x = s.Count();
    int count = 0;
    for (int i = 0; i < x; i += 3)
    {
        int j = i;
        if (s[j] != 'S')
        {
            count += 1;
        }
        if (s[j+1] != 'O')
        {
            count += 1;
        }
        if (s[j + 2] != 'S')
        {
            count += 1;
        }
    }
    Console.WriteLine(count);
    return count;
}

marsExploration("SOSOSOSOSDSDSKWOSDOSDOASDOASDFAFJDFDOSOSOWNSOSOSNDSKDDOSOSOSJDSDSOOSOSDSDOSASSOASDSAOSOSODSDSOASDWS");