
public class OrderRepositoryList
{
    private List<Order> _orders;

    public OrderRepositoryList()
    {
        _orders = new List<Order>();
    }

    public void AddOrder(Order order) //Der må ikke tilføjes 2 ordrer med samme ordrer nummer
    {
        foreach (Order o in _orders)
        {
            if (o.OrderId == order.OrderId) return;
        }
        _orders.Add(order);
    }

    public Order? SearchOrder(int orderNumber)
    {
        foreach (Order o in _orders)
        {
            if (o.OrderId == orderNumber) return o;
        }
        return null;
    }

    public void DeleteOrder(int orderNumber)
    {
        _orders.Remove(SearchOrder(orderNumber));
    }


    public void UpdateOrder(int orderNumber, Order upDatedOrder)
    {
        DeleteOrder(orderNumber);
        AddOrder(upDatedOrder);
    }

    public void PrintAll()
    {
        foreach (Order order in _orders)
        {
            Console.WriteLine(order.ToString());
        }
    }

}

