namespace OOP1;

public class Currency
{
    protected string Name = "Euro";
    protected double ExRate = 40.5;

    public Currency()
    {
        
    }
    
    public Currency(string name, double exRate)
    {
        Name = name;
        ExRate = exRate;
    }
    public Currency(string name)
    {
        Name = name;
    }
    public Currency(double exRate)
    {
        ExRate = exRate;
    }

    public Currency(Currency currency) : this(currency.Name, currency.ExRate)
    {
        
    }

    public void SetName(string name)
    {
        Name = name;
    }
    
    public string GetName()
    {
        return Name;
    }

    public void SetExRate(double exRate)
    {
        ExRate = exRate;
    }

    public double GetExRate()
    {
        return ExRate;
    }
}