

static void miniMaxSum(List<int> arr)
{
    int result = 0;
    int minSum = 0;
    int maxSum = 0;
    bool passedFirst = false;
    for (int i = 0; i < arr.Count; i++)
    {
        result = 0;
        for (int j = 0; j < arr.Count; j++)
        {
            if(i != j)
            {
                result = result + arr[j];
            }
        }

        if(!passedFirst)
        {
            passedFirst = true;
            minSum = result;
        }

        if(result < minSum)
        {
            minSum = result;
        }

        if (result > maxSum)
        {
            maxSum = result;
        }
        Console.WriteLine(i+". Result: " + result);
    }

    Console.WriteLine("Max: " + maxSum);
    Console.WriteLine("Min: " + minSum);
}

List <int> arr = new List<int> { 1, 3, 6, 8, 10 };
miniMaxSum(arr);
