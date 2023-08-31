static List<int> gradingStudents(List<int> grades)
{
    List<int> rounded = new List<int>();
    int index = 0;
    foreach (int grade in grades)
    {
        if((grade + 1) % 5 == 0 && grade + 1 >= 40)
        {
            rounded.Add(grade + 1);
        }

        else if ((grade + 2) % 5 == 0 && grade + 2 >= 40)
        {
            rounded.Add(grade + 2);
        }

        else
        {
            rounded.Add(grade);
        }

        Console.WriteLine(rounded[index]);
        index++;
    }

    return rounded;
}


List<int> grades  = new List<int> { 30, 40, 28, 69, 100, 80};
gradingStudents(grades);