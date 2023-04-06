namespace PizzaModelLibrary
{
    public class Pizza : IEquatable<Pizza>, IComparable<Pizza>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Price { get; set; }
        public int CompareTo(Pizza? other)
        {
            return this.Id.CompareTo(other.Id);
        }
        public Pizza()
        {
            
        }

        public Pizza(int id, string? name, double? price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public bool Equals(Pizza? other)
        {
            return this.Id.Equals(other.Id);
        }
        public override string ToString()
        {
            return "Id " + Id + " Name " + Name + " Price : Rs." + Price;
        }
    }
}