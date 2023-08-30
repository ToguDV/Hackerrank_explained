static string timeConversion(string s)
{
    string hours = s.Substring(0, 2);
    string minutes = s.Substring(3, 2);
    string seconds = s.Substring(6, 2);
    string meridiem = s.Substring(8, 2);
    int hoursInt = Int16.Parse(hours);

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

/* The formula to convert to 24 hours format when is "PM" : hours + 12 hours
 * Example: 4:35 PM + 12 hours = 16:35
 * 
 * 
 */
Console.WriteLine(timeConversion("07:05:45PM"));
Console.WriteLine(timeConversion("12:45:54PM"));