
    public class Customer
    {
        public string Name { get; }
        public string Address { get; }
        public int Id { get; }
        public static int NextId;

        public Customer(string name, string address)
        {
            Name = name;
            Address = address;
            Id = NextId++;
        }

        public override string ToString()
        {
            return $"name: {Name}, address: {Address}, customer id: {Id}";
        }
    }

