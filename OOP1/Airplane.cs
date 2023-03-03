namespace OOP1;

public class Airplane
{
    protected string StartCity;
    protected string FinishCity;
    protected Date StartDate;
    protected Date FinishDate;

    public Airplane()
    {
        StartCity = "Zhytomyr";
        FinishCity = "London";
        StartDate = new Date();
        FinishDate = new Date();
    }

    public Airplane(string startCity, string finishCity, Date startDate, Date finishDate)
    {
        StartCity = startCity;
        FinishCity = finishCity;
        StartDate = new Date(startDate);
        FinishDate = new Date(finishDate);
    }
    public Airplane(string startCity,  Date startDate)
    {
        StartCity = startCity;
        StartDate = new Date(startDate);
    }
    

    public Airplane(Airplane airplane) : this(airplane.StartCity, airplane.FinishCity, airplane.StartDate, airplane.FinishDate)
    {
        
    }

    public void SetStartCity(string startCity)
    {
        StartCity = startCity;
    }

    public string GetStartCity()
    {
        return StartCity;
    }
    public void SetFinishCity(string finishCity)
    {
        FinishCity = finishCity;
    }

    public string GetFinishCity()
    {
        return FinishCity;
    }

    public void SetStartDate(Date startDate)
    {
        StartDate = startDate;
    }

    public Date GetStartDate()
    {
        return StartDate;
    }
    
    public void SetFinishDate(Date finishDate)
    {
        FinishDate = finishDate;
    }

    public Date GetFinishDate()
    {
        return FinishDate;
    }

    public string GetFullStartDate()
    {
        return $"{StartDate.GetYear()}.{StartDate.GetMonth()}.{StartDate.GetDay()}.{StartDate.GetHours()}.{StartDate.GetMinutes()}";
    }
    public string GetFullFinishDate()
    {
        return $"{FinishDate.GetYear()}.{FinishDate.GetMonth()}.{FinishDate.GetDay()}.{FinishDate.GetHours()}.{FinishDate.GetMinutes()}";
    }

    public int GetTotalTime()
    {
        int totalHours, totalMinutes, totalTime;
        if (StartDate.GetHours() <= FinishDate.GetHours())
            totalHours = FinishDate.GetHours() - StartDate.GetHours();
        else
            totalHours = FinishDate.GetHours() - StartDate.GetHours() + 24;
        if (StartDate.GetMinutes() >= FinishDate.GetMinutes())
            totalMinutes = StartDate.GetMinutes() - FinishDate.GetMinutes();
        else
            totalMinutes = FinishDate.GetMinutes() - StartDate.GetMinutes();
        totalTime = 60 * totalHours + totalMinutes;
        return totalTime;

    }

    public bool IsArrivingToday()
    {
        if (StartDate.GetDay() == FinishDate.GetDay())
            return true;
        else
            return false;
    }
}
