static int lonelyinteger(List<int> a)
{
    bool unique;
    int uniqueValue = 0;
    for (int i = 0; i < a.Count; i++)
    {
        unique = true;
        for (int j = 0; j < a.Count; j++)
        {
            if (a[i] == a[j] && j != i)
            {
                unique = false;
                break;
            }
        }

        if(unique)
        {
            uniqueValue = a[i];
            
        }
    }
    return uniqueValue;
}

List<int> a = new List<int> { 1, 2, 3, 4, 3, 2, 1 };
Console.WriteLine(lonelyinteger(a));
