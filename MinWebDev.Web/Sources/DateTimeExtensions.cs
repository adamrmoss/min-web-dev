namespace MinWebDev.Web;

public static class DateTimeExtensions
{
    public static string ToShortMonthYearString(this DateTime? dateTime)
        => dateTime?.ToShortMonthYearString() ?? "Present";
    
    public static string ToShortMonthYearString(this DateTime dateTime)
        => dateTime.ToString("MMM yyyy");
}
