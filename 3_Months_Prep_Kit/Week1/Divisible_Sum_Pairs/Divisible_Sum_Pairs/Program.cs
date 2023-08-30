



static int divisibleSumPairs(int n, int k, List<int> ar)
{

    int pairsCount = 0;
    List<int> alreadyUsed = new List<int> { -10 };


    for (int i = 0; i < ar.Count; i++)
    {
        for (int j = 0; j < ar.Count; j++)
        {
            if (i < j)
            {
                int sum = ar[i] + ar[j];

                //Checking if sum is divisible by k
                if (sum % k == 0)
                {
                    for (int m = 0; m < alreadyUsed.Count; m++)
                    {
                        // Checking if this number is already used
                        if (alreadyUsed[m] == ar[i])
                        {
                            break;
                        }
                    }

                    alreadyUsed.Add(ar[i]);
                    pairsCount++;


                }
            }
        }
    }

    Console.WriteLine("Pairs:" + pairsCount);
    return pairsCount;
}




List<int> ar = new List<int> { 1, 3, 2, 6, 1, 2 };
divisibleSumPairs(6, 3, ar);
