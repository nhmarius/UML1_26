
public class Pizza
{
    public int MenuNumber { get; }
    public string Name { get;  }
    public double Price { get; set; }
    public List<string> ToppingsList { get; set; }
 
    public Pizza(int menuNumber, string name, double price, List<string> toppingsList)
    {
        MenuNumber = menuNumber;
        Name = name;
        Price = price;
        ToppingsList = toppingsList;
    }
    public override string ToString()
    {
        return $"number: {MenuNumber}, name: {Name}, price: {Price}, toppings: {String.Join(", ", ToppingsList)}";
    }
}
