using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1._1
{
    class Food
    {
        string name;
        string[] ingredients;
        double price;
        float calories;
        public Food()
        {

        }
        public Food(string name, string[] ingredients, double price, float calories)
        {
            this.name = name;
            this.ingredients = ingredients;
            this.price = price;
            this.calories = calories;
        }
        void setName(string name)
        {
            this.name = name;

        }
        public string getName()
        {
            return this.name;
        }
        void setingredients(string[] ingredients)
        {
            this.ingredients = ingredients;
        }
        public string[] getingredients()
        {
            return this.ingredients;
        }
        void setprice(double price)
        {
            this.price = price;
        }
        public double getprice()
        {
            return this.price;
        }

        void setcalories(float calories)
        {
            this.calories = calories;
        }
        public float getcalories()
        {
            return this.calories;
        }
      




        public void showDetails()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Ingredients  : " + string.Join(",", this.ingredients));
            Console.WriteLine("price  :" + price);
            Console.WriteLine("calories :" + calories);
        }
    }

    class Drink : Food
    {
        string type { set; get; }
        int sizeInLitter { set; get; }
       public Drink() : base() { }
        public Drink(string name, string[] ingredients, double price, float calories, string type, int sizeInLitter) : base(name, ingredients, price, calories)
        {

            this.type = type;
            this.sizeInLitter = sizeInLitter;

        }
        public new void showDetails()
        {
            base.showDetails();
            Console.WriteLine("Size In Litter: " + sizeInLitter);



        }
    }
    class Burger : Food
    {
        int numberOfPatty { set; get; }

        public Burger() : base()
        {

        }
        public Burger(String name, String[] ingredients, double price, float calories, int numberOfPatty) : base(name, ingredients, price, calories)
        {
            this.numberOfPatty = numberOfPatty;
        }

        public new void showDetails()
        {
            base.showDetails();
            Console.WriteLine(" NUmber Of patty: " + numberOfPatty);


        }
    }
    class Pizza : Food
    {
        int sizeInInches { set; get; }
        public Pizza() : base()
        {

        }
        public Pizza(String name, String[] ingredients, double price, float calories, int sizeInInches) : base(name, ingredients, price, calories)
        {
            this.sizeInInches = sizeInInches;
        }

        public new void showDetails()
        {
            base.showDetails();
            Console.WriteLine(" sizeInInches: " + sizeInInches);


        }
    }
    class Restaurant
    {
        string restaurantName;

        Drink[] drinks = new Drink[100];
        Burger[] burgers = new Burger[100];
        Pizza[] pizzas = new Pizza[100];
        public Restaurant() { }

        public Restaurant(string restaurantName)
        {
            this.restaurantName = restaurantName;
        }
        public void setRestaurantName(string restaurantName)
        {
            this.restaurantName = restaurantName;
        }

        public string getRestaurantName()
        {
            return restaurantName;
        }

        public void addDrink(Drink d)
        {
            for (int i = 0; i < drinks.Length; i++)
            {
                if (drinks[i] == d)
                {
                    drinks[i] = d;
                }
            }
        }
       public void removeDrink(Drink d)
        {
            for (int i = 0; i < drinks.Length; i++)
            {
                if (drinks[i] == d)
                {
                    drinks[i] = null;
                }

            }
        }
        public void showDrink()
        {
            Console.WriteLine("Drinks:");
            foreach (Drink d in drinks)
            {
                if (d != null)
                {
                    Console.WriteLine("  " + d.getName() + " (" + d.getprice() + ")");
                }
            }
        }
       
        public double calculateDrinkBill()
        {
            double total = 0;
            foreach (Drink d in drinks)
            {
                if (d != null)
                {
                    total += d.getprice();
                }
            }
            return total;
        }

        public void addBurger(Burger b)
        {
            for (int i = 0; i < burgers.Length; i++)
            {
                if (burgers[i] == b)
                {
                    burgers[i] = b;
                }
            }
        }
        public void removeBurger(Burger b)
        {
            for (int i = 0; i < burgers.Length; i++)
            {
                if (burgers[i] == b)
                {
                    burgers[i] = null;
                }

            }
        }
        public void showBurger()
        {
            Console.WriteLine("Burgers:");
            foreach (Burger b in burgers)
            {
                if (b != null)
                {
                    Console.WriteLine(" " + b.getName() + " (" + b.getprice() + ")");
                }
            }
        }

        public double calculateBurgerBill()
        {
            double total = 0;
            foreach (Burger b in burgers)
            {
                if (b != null)
                {
                    total += b.getprice();
                }
            }
            return total;
        }
        public void addPizza(Pizza p)
        {
            for (int i = 0; i < pizzas.Length; i++)
            {
                if (pizzas[i] == null)
                {
                    pizzas[i] = p;
                    
                }
            }
        }


        public void removePizza(Pizza p)
        {
            for (int i = 0; i < pizzas.Length; i++)
            {
                if (pizzas[i] == p)
                {
                    pizzas[i] = null;
                    
                }
            }
        }

        public void showPizza()
        {
            Console.WriteLine("Pizzas:");
            foreach (Pizza p in pizzas)
            {
                if (p != null)
                {
                    Console.WriteLine(" " + p.getName() + " (" + p.getprice() + ")");
                }
            }
        }

        public double calculatePizzaBill()
        {
            double total = 0;
            foreach (Pizza p in pizzas)
            {
                if (p != null)
                {
                    total += p.getprice();
                }
            }
            return total;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Restaurant restaurant= new Restaurant("3_bhai resturant");

            Restaurant restaurant = new Restaurant("Resturant1");


            Drink drink1 = new Drink("Cocacola", new string[] { "sugar", "water" }, 2.50, 150, "soft drink", 1);
            Drink drink2 = new Drink("Sprite", new string[] { "sugar", "water" }, 2.50, 150, "soft drink", 1);
            Drink drink3 = new Drink("Fanta", new string[] { "sugar", "water" }, 2.50, 150, "soft drink", 1);
            Drink drink4 = new Drink("7up", new string[] { "sugar", "water" }, 2.50, 150, "soft drink", 1);
            Drink drink5 = new Drink("mojo", new string[] { "sugar", "water" }, 2.50, 150, "soft drink", 1);
            restaurant.addDrink(drink1);
            restaurant.addDrink(drink2);
            restaurant.addDrink(drink3);
            restaurant.addDrink(drink4);
            restaurant.addDrink(drink5);


            Burger burger1 = new Burger("Big burger", new string[] { "beef patty", "lettuce", "tomato", "onions", "pickles" }, 5.00, 600, 2);
            Burger burger2 = new Burger("middum burger", new string[] { "beef patty", "lettuce", "tomato", "onions", "pickles" }, 6.00, 700, 1);
            Burger burger3 = new Burger("light burger", new string[] { "beef patty", "lettuce", "tomato", "onions", "pickles" }, 6.00, 700, 1);
            Burger burger4 = new Burger("burger king", new string[] { "beef patty", "lettuce", "tomato", "onions", "pickles" }, 6.00, 700, 1);
            Burger burger5 = new Burger("dream burger", new string[] { "beef patty", "lettuce", "tomato", "onions", "pickles" }, 6.00, 700, 1);
            restaurant.addBurger(burger1);
            restaurant.addBurger(burger2);
            restaurant.addBurger(burger3);
            restaurant.addBurger(burger4);
            restaurant.addBurger(burger5);


            Pizza pizza1 = new Pizza("big pizza", new string[] { " tomato sauce", "cheese", "pepperoni", " mushrooms", "onions", "peppers", " sausage", " olives", "bacon" }, 56.0, 566, 5);
            Pizza pizza2 = new Pizza("big pizza", new string[] { " tomato sauce", "cheese", "pepperoni", " mushrooms", "onions", "peppers", " sausage", " olives", "bacon" }, 56.0, 566, 5);
            Pizza pizza3 = new Pizza("big pizza", new string[] { " tomato sauce", "cheese", "pepperoni", " mushrooms", "onions", "peppers", " sausage", " olives", "bacon" }, 56.0, 566, 5);
            Pizza pizza4 = new Pizza("big pizza", new string[] { " tomato sauce", "cheese", "pepperoni", " mushrooms", "onions", "peppers", " sausage", " olives", "bacon" }, 56.0, 566, 5);
            Pizza pizza5 = new Pizza("big pizza", new string[] { " tomato sauce", "cheese", "pepperoni", " mushrooms", "onions", "peppers", " sausage", " olives", "bacon" }, 56.0, 566, 5);

            restaurant.addPizza(pizza1);
            restaurant.addPizza(pizza2);
            restaurant.addPizza(pizza3);
            restaurant.addPizza(pizza4);
            restaurant.addPizza(pizza5);


            restaurant.showDrink();
            restaurant.showPizza();
            restaurant.showBurger();
            Console.ReadLine();

        }
      
    }
    
}
