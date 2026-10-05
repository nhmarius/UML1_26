
public class OrderLine
{
    public Pizza Pizza { get; set; }
    public int Amount { get; set; }
    public string Comment { get; set; }
    public bool _canAddTopping = false;
    public List<Topping> ToppingList = new List<Topping>();
    public OrderLine(Pizza pizza, int amount, string comment)
    {
        Pizza = pizza;
        Amount = amount;
        Comment = comment;
    }
    public OrderLine(Pizza pizza, int amount)
    {
        Pizza = pizza;
        Amount = amount;
        Comment = "no comment";
    }
    public OrderLine(Pizza pizza, string comment)
    {
        Pizza = pizza;
        Amount = 1;
        _canAddTopping = true;
        Comment = comment;
    }
    public OrderLine(Pizza pizza)
    {
        Pizza = pizza;
        Amount = 1;
        _canAddTopping = true;
        Comment = "no comment";
    }
    public void AddTopping(Topping topping)
    {
        if (_canAddTopping) ToppingList.Add(topping);

    }
    public double ToppingPrice()
    {
        double total = 0;
        foreach (Topping topping in ToppingList)
        {
            total += topping.Price;
        }
        return total;
    }
    public string ToppingPrint() 
    {
        string returnValue = "";
        foreach (Topping topping in ToppingList) returnValue += topping.Name + ", ";
        return returnValue;
    }
        
    public override string ToString()
    {
        if (ToppingList.Count>0)
        {
            return $"amount: {Amount}, {Pizza.ToString()}, \nextra toppings: {ToppingPrint()}comment: {Comment}";
        }
        return $"amount: {Amount}, {Pizza.ToString()}, comment: {Comment}";

    }
}
