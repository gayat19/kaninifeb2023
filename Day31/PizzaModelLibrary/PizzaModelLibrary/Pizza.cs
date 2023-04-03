namespace PizzaModelLibrary
{
    public class Pizza
    {
        public string[] toppings;

        public string this[int index]
        {
            get { return toppings[index]; }
            set { toppings[index] = value; }
        }
        public override string ToString()
        {
            string message = "";

            message += "Pizza Details";
            message += $"\nPizza Id : {Id}";//Interpollation
            message += $"\nPizza name : {Name}";//Interpollation
            message += $"\nPizza price : Rs.{Price}";//Interpollation
            for (int i = 0; i < toppings.Length; i++)
            {
                message += $"\n\tTopping {toppings[i]}";
            }
            return message;
        }
        public int this[string name]
        {
            get
            {
                for (int i = 0; i < toppings.Length; i++)
                {
                    if (toppings[i].ToUpper() == name.ToUpper())
                    {
                        return i;
                    }
                }
                return -1;
            }
        }
        /// <summary>
        /// Default constructor that will initialize the topping size to 5
        /// </summary>
        public Pizza()
        {
            toppings = new string[2];
        }
        /// <summary>
        /// Except tpping all the properties have to taken in
        /// </summary>
        /// <param name="toppingCount">This will be the number of toppings you can add</param>
        public Pizza(int toppingCount)
        {
            toppings = new string[toppingCount];
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="price">Price of teh pizza in INR</param>
        /// <param name="name">Name of the pizza for order</param>
        /// <param name="id">An Unique ID for the pizza</param>

        public Pizza(double price, string? name, int id) : this()
        {
            Price = price;
            Name = name;
            Id = id;
        }
        /// <summary>
        /// All in one
        /// </summary>
        /// <param name="price"></param>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="toppingCount"></param>
        public Pizza(double price, string? name, int id, int toppingCount) : this(price, name, id)
        {
            toppings = new string[toppingCount];
        }

        public double Price { get; set; }
        public string? Name { get; set; }
        public int Id { get; set; }

        protected virtual void TakeDetails()
        {
            Console.WriteLine("Please enter the Pizza Name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the Pizza Price");
            double price = 0;
            while (!double.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("You don't even know to entrr price preperly. Who made you the data entry person???");
            }
            Price = price;
            if(price<1)
                throw new InvalidPriceException();
            //Console.WriteLine("How many toppings do you like to add??");
            //int toppingsCount = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the toppings");
            for (int i = 0; i < toppings.Length; i++)
            {
                toppings[i] = Console.ReadLine();
            }
        }

        public void TakePizzaDetails()
        {
            Console.WriteLine("Please enter the Pizza Id");
            Id = Convert.ToInt32(Console.ReadLine());
            TakeDetails();
        }

        public void TakePizzaDetails(int id)
        {
            Id = id;
            TakeDetails();
        }
        public static Pizza operator +(Pizza left, Pizza right)
        {
            Pizza pizza = new Pizza();
            pizza.Price = left.Price + right.Price;
            pizza.Id = left.Id;
            pizza.Name = left.Name + " " + right.Name;
            // pizza.toppings = new string[left.toppings.Length+right.toppings.Length];

            return pizza;
        }
        //public static bool operator ==(Pizza left, Pizza right)
        //{
        //    bool result = false;
        //    if (left.Price == right.Price && left.Name == right.Name)
        //        result = true;
        //    return result;
        //}
        //public static bool operator !=(Pizza left, Pizza right)
        //{
        //    bool result = true;
        //    if (left.Price == right.Price && left.Name == right.Name)
        //        result = false;
        //    return result;
        //}///
    }
}