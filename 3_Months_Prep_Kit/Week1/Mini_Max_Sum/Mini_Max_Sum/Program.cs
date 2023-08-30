

static void miniMaxSum(List<int> arr)
{
    long min = arr[0];
    long max = 0;
    long sum = 0;
    for (int i = 0; i < arr.Count; i++)
    {
        //We add up each number in the array
        sum += arr[i];

        //We obtain the smallest number
        if (arr[i] < min)
        {
            min = arr[i]; 
        }

        //We obtain the largest number
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }

    //Why subtract these two numbers? see section [0]
    Console.WriteLine((sum - max) + " " + (sum - min));
}

//Example list
List <int> arr = new List<int> { 1, 3, 6, 8, 10 };
miniMaxSum(arr);



//SECTION [0]

/*
 * 1. The problem ask you to get the min & max sum between 4 numbers.
 * 2. The array length is 5 numbers in total. It means one number always is left over in the sum.
 * 3. The number left over in the minium sum is the largest number. miniumSum = (sum - max)
 * 4. The number left over in the maximum sum is the smallest number. maximumSum = (sum - max)
 * 
 * Are things clearer to you now? :)
 * 
 */