
    public class Order
    {
        public List<OrderLine> OrderLineList { get; }
        public Customer Customer { get; }
        public int OrderId { get; }
        public bool IsDelivery { get; set; }


        public static int NextId;

        public Order(List<OrderLine> orderLineList, Customer customer, bool isDelivery)
        {
            OrderLineList = orderLineList;
            Customer = customer;
            IsDelivery = isDelivery;

            OrderId = ++NextId;
        }
        public double CalulatePrice()
        {
            double totalPrice = 0;
            foreach (OrderLine orderLine in OrderLineList)
            {
                totalPrice += orderLine.Pizza.Price * orderLine.Amount;
            }

            //skal moms på før man tilføjer leveringsomkostninger? undersøg
            if (IsDelivery) totalPrice += 40;
            totalPrice *= 1.25;
            return totalPrice;
        }
        public string PrintPizzas()
        {
            string returnString = "";
            foreach (OrderLine orderLine in OrderLineList)
            {
                returnString += $"\n{orderLine.ToString()}";
            }
            return returnString;
        }
        public override string ToString()
        {
            return $"order number: {OrderId}\nordered by: {Customer.ToString()}\nordered pizzas: {PrintPizzas()}\ntotal price: {CalulatePrice()}\ndelivery: {IsDelivery}";
        }
    }
