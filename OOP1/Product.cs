namespace OOP1;

public class Product
{
    protected string Name;
    protected double Price;
    protected Currency Cost;
    protected int Quantity;
    protected string Producer;
    protected double Weight;

    public Product()
    {
        Name = "Milk";
        Price = 1.05;
        Cost = new Currency();
        Quantity = 140;
        Producer = "MMMilk";
        Weight = 1;
    }

    public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
    {
        Name = name;
        Price = price;
        Cost = new Currency();
        Quantity = quantity;
        Producer = producer;
        Weight = weight;
    }
    public Product(string name, double price, Currency cost)
    {
        Name = name;
        Price = price;
        Cost = new Currency();
    }

    public Product(Product product) : this(product.Name, product.Price, product.Cost, product.Quantity,
        product.Producer, product.Weight)
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

    public void SetPrice(double price)
    {
        Price = price;
    }

    public double GetPrice()
    {
        return Price;
    }

    public void SetCost(Currency cost)
    {
        Cost = cost;
    }

    public Currency GetCost()
    {
        return Cost;
    }

    public void SetQuantity(int quantity)
    {
        Quantity = quantity;
    }

    public int GetQuantity()
    {
        return Quantity;
    }

    public void SetProducer(string producer)
    {
        Producer = producer;
    }

    public string GetProducer()
    {
        return Producer;
    }

    public void SetWeight(double weight)
    {
        Weight = weight;
    }

    public double GetWeight()
    {
        return Weight;
    }

    public double GetPriceInUAH()
    {
        return GetPrice() * Cost.GetExRate();
    }

    public double GetTotalPriceInUAH()
    {
        return GetPriceInUAH() * GetQuantity();
    }

    public double GetTotalWeight()
    {
        return GetWeight() * GetQuantity();
    }
}