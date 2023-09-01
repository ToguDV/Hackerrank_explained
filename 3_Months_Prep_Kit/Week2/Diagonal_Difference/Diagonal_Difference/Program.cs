static int diagonalDifference(List<List<int>> arr)
{
    int diagonal1 = 0;
    int diagonal2 = 0;
    int inverseIndex = arr.Count() -1;
    int diff = 0;
    for (int i = 0; i < arr.Count(); i++)
    {
        diagonal1 += arr[i][i]; 
        diagonal2 += arr[i][inverseIndex];
        inverseIndex--;
    }
    diff = Math.Abs(diagonal1 - diagonal2);
    Console.WriteLine(diff);
    return diff;

}

List<int> a = new List<int> { 11, 22, 4 };
List<int> b = new List<int> { 4, 5, 6 };
List<int> c = new List<int> { 10, 8, -12 };

List<List<int>> arr = new List<List<int>> { a, b, c };
diagonalDifference(arr);
