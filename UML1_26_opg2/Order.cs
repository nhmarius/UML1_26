
    public class Order
    {
        public List<Pizza> PizzaList { get; }
        public Customer Customer { get; }
        public int OrderId { get; }
        public bool IsDelivery { get; set; }

        public static int NextId;

        public Order(List<Pizza> pizzaList, Customer customer, bool isDelivery)
        {
            PizzaList = pizzaList;
            Customer = customer;
            IsDelivery = isDelivery;

            OrderId = NextId++;
        }
        public double CalulatePrice()
        {
            double totalPrice = 0;
            foreach (Pizza pizza in PizzaList)
            {
                totalPrice += pizza.Price;
            }

            //skal moms på før man tilføjer leveringsomkostninger? undersøg
            if (IsDelivery) totalPrice += 40;
            totalPrice *= 1.25;
            return totalPrice;
        }
        public string PrintPizzas()
        {
            string returnString = "";
            foreach (Pizza pizza in PizzaList)
            {
                returnString += $"\n{pizza.ToString()}";
            }
            return returnString;
        }
        public override string ToString()
        {
            return $"order number: {OrderId}\nordered by: {Customer.ToString()}\nordered pizzas: {PrintPizzas()}\ntotal price: {CalulatePrice()}\ndelivery: {IsDelivery}";
        }
    }
