
static List<int> CountingSort(List<int> arr)
{
    List<int> count = new List<int>(new int[100]);

    for (int i = 0; i < arr.Count(); i++)
    {
        count[arr[i]]++;
    }

    return count;
}

