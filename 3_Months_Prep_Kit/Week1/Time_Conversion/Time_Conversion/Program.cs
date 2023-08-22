static string timeConversion(string s)
{
    string hours = "";
    int hoursInt = 0;
    string minutes = "";
    string seconds = "";
    string meridiem = "";

    hours = s.Substring(0, 2);
    minutes = s.Substring(3, 2);
    seconds = s.Substring(6, 2);
    meridiem = s.Substring(8, 2);

    hoursInt = Int16.Parse(hours);


    if(meridiem.Equals("PM") && hoursInt != 12)
    {
        hoursInt += 12;
        hours = hoursInt.ToString();
    }

    else if(meridiem.Equals("AM") && hoursInt == 12)
    {
        hours = "00";
    }



    return hours+":"+minutes+":"+seconds;


}


Console.WriteLine(timeConversion("07:05:45PM"));
Console.WriteLine(timeConversion("12:45:54PM"));