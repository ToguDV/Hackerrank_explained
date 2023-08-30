

static void miniMaxSum(List<int> arr)
{
    long min = arr[0];
    long max = 0;
    long sum = 0;
    for (int i = 0; i < arr.Count; i++)
    {
        sum += arr[i];

        if(arr[i] < min)
        {
            min = arr[i];
        }

        if (arr[i] > max)
        {
            max = arr[i];
        }
    }

    Console.WriteLine((sum - max) + " " + (sum - min));
}

List <int> arr = new List<int> { 1, 3, 6, 8, 10 };
miniMaxSum(arr);
