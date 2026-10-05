
    public class OrderLine
    {
        public Pizza Pizza { get; set; }
        public string Comment { get; set; }
        public OrderLine(Pizza pizza, string comment)
        {
            Pizza = pizza;
            Comment = comment;
        }
        public override string ToString()
        {
            return $"{Pizza.ToString()}, comment: {Comment}";
        }
    }
