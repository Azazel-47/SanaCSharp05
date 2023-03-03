namespace OOP1;

public class Date
{
    protected int Year;
    protected int Month;
    protected int Day;
    protected int Hours;
    protected int Minutes;

    public Date()
    {
        Year = 2023;
        Month = 03;
        Day = 24;
        Hours = 6;
        Minutes = 35;
    }
    public Date(int year, int month, int day, int hours, int minutes)
    {
        Year = year;
        Month = month;
        Day = day;
        Hours = hours;
        Minutes = minutes;
    }
    
    public Date(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    public Date(Date date) : this(date.Year, date.Month, date.Day, date.Hours, date.Minutes)
    {
        
    }

    public void SetYear(int year)
    {
        Year = year;
    }

    public int GetYear()
    {
        return Year;
    }
    
    public void SetMonth(int month)
    {
        Month = month;
    }

    public int GetMonth()
    {
        return Month;
    }

    public void SetDay(int day)
    {
        Day = day;
    }

    public int GetDay()
    {
        return Day;
    }

    public void SetHours(int hours)
    {
        Hours = hours;
    }

    public int GetHours()
    {
        return Hours;
    }

    public void SetMinutes(int minutes)
    {
        Minutes = minutes;
    }

    public int GetMinutes()
    {
        return Minutes;
    }
    
}