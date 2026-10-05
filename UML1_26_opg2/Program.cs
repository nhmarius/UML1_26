Console.WriteLine("opgave 2\n");

Customer customer1 = new("marius", "street 123");
Customer customer2 = new("mikkel", "somewhere 66");
Customer customer3 = new("aksel", "placename 17");

List<string> margheritaToppings = new List<string> { "tomato", "cheese"};
Pizza pizza1 = new(1, "margherita", 69, margheritaToppings);
List<string> bigMammaToppings = new List<string> { "tomato", "gorgonzola", "shrimp", "asparagus", "parma ham"};
Pizza pizza2 = new(19, "big mamma", 90, bigMammaToppings);
List<string> esoticaToppings = new List<string> { "tomato", "cheese","ham","shrimp","pineapple"};
Pizza pizza3= new(14, "esotica", 80, esoticaToppings);

Console.WriteLine(customer1.ToString());
Console.WriteLine(customer2.ToString());
Console.WriteLine(customer3.ToString());

Console.WriteLine(pizza1.ToString());
Console.WriteLine(pizza2.ToString());
Console.WriteLine(pizza3.ToString());

Console.WriteLine();
Console.WriteLine();

List<Pizza> pizzaList1 = new List<Pizza> { pizza2, pizza3};
Order order1 = new(pizzaList1, customer1, true);

Console.WriteLine(order1.ToString());
