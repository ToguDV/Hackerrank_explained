static int countingValleys(int steps, string path)
{
    int level = 0;
    int valleys = 0;
    bool insideValley = false;

    for (int i = 0; i < path.Length; i++)
    {
        char step = path[i];

        if (step == 'U')
        {
            level++;
        }
        else if (step == 'D')
        {
            level--;
        }

        if (level < 0 && !insideValley)
        {
            insideValley = true;
        }

        if (level == 0 && insideValley)
        {
            valleys++;
            insideValley = false;
        }
    }

    return valleys;
}

string path = "DDUUDDDUDUUDUDDDUUDDUDDDUDDDUDUUDDUUDDDUDDDUDDDUUUDUDDDUDUDUDUUDDUDUDUDUDUUUUDDUDDUUDUUDUUDUUUUUUUUU";
int result = countingValleys(10, path);
Console.WriteLine(result);