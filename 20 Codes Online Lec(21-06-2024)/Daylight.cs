using System;

class Program
{
    static void Main()
    {
        
        string timeZoneId = "India Standard Time"; 
        TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);

        DateTime now = DateTime.Now;
        bool isDaylightSaving = timeZone.IsDaylightSavingTime(now);

        Console.WriteLine("Time Zone: {0}", timeZone.DisplayName);
        Console.WriteLine("Current Date and Time: {0}", now);
        Console.WriteLine("Is Daylight Saving Time: {0}", isDaylightSaving);
    }
}