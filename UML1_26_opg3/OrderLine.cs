
    public class OrderLine
    {
        public Pizza Pizza { get; set; }
        public int Amount { get; set; }
        public string Comment { get; set; }
        public OrderLine(Pizza pizza, int amount, string comment)
        {
            Pizza = pizza;
            Amount = amount;
            Comment = comment;
        }
        public override string ToString()
        {
            return $"amount: {Amount}, {Pizza.ToString()}, comment: {Comment}";
        }
    }
