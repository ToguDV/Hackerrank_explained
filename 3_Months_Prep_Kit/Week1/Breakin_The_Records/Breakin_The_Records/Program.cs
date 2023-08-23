static List<int> breakingRecords(List<int> scores)
{

    int timesMost = 0;
    int timesLeast = 0;
    int mostRecord = scores[0];
    int leastRecord = scores[0];

    for (int i = 1; i < scores.Count; i++)
    {
        if (scores[i] > mostRecord)
        {
            mostRecord = scores[i];
            timesMost++;
        }

        if (scores[i] < leastRecord)
        {
            leastRecord = scores[i];
            timesLeast++;
        }
    }
    List<int> timesRecord = new List<int> { timesMost, timesLeast };
    //Console.WriteLine(timesRecord[0] + "-" + timesRecord[1]);
    return timesRecord;
}


List<int> scores = new List<int>() { 10, 5, 20, 20, 4, 5, 2, 25, 1 };

breakingRecords(scores);