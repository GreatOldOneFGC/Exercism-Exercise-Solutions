static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        var date = appointmentDateDescription[..^8];
        int month;
        int day;
        int year;

        if (date.Contains(","))
        {
            var splitDate = date.Split(", ");

            if (splitDate.Length > 2)

            {
                splitDate = [splitDate[1], splitDate[2]];
            }

            var monthAndDay = splitDate[0].Split(' ');

            month = monthAndDay[0] switch
            {
                "January" => 1,
                "February" => 2,
                "March" => 3,
                "April" => 4,
                "May" => 5,
                "June" => 6,
                "July" => 7,
                "August" => 8,
                "September" => 9,
                "October" => 10,
                "November" => 11,
                "December" => 12,
                _ => 0,
            };

            day = int.Parse(monthAndDay[1]);
            year = int.Parse(splitDate[1]);

        }
        else
        {
            var dates = date.Split('/');
            month = int.Parse(dates[0]);
            day = int.Parse(dates[1]);
            year = int.Parse(dates[2]);
        }

        var times = appointmentDateDescription[^8..].Split(':');
        var hours = int.Parse(times[0]);
        var minutes = int.Parse(times[1]);
        var seconds = int.Parse(times[2]);
        return new DateTime(year, month, day, hours, minutes, seconds);
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        var currentDate = DateTime.Now;
        return appointmentDate < currentDate;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate) => appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;

    public static string Description(DateTime appointmentDate)
    {
        var minutes = AddLeadingZero(appointmentDate.Minute);
        var seconds = AddLeadingZero(appointmentDate.Second);
        var hours = appointmentDate.Hour > 12 ? appointmentDate.Hour - 12 : appointmentDate.Hour;

        return $"You have an appointment on {appointmentDate.Month}/{appointmentDate.Day}/{appointmentDate.Year} {hours}:{minutes}:{seconds} {(appointmentDate.Hour >= 13 ? "PM" : "AM")}.";
    }

    private static string AddLeadingZero(int time) => time >= 10 ? time.ToString() : $"0{time}";

    public static DateTime AnniversaryDate() => new(DateTime.Now.Year, 9, 15, 0, 0, 0);
}
