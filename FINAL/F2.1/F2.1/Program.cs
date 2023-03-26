

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2_1
{
    public class Resturant
    {
        protected String restaurantName;
        protected Drinks[] drinks;
        protected Burger[] burgers;
        protected Pizza[] pizza;
        public double calculateBill;
        public Resturant()
        {

        }
        public Resturant(string restaurantName)
        {
            this.restaurantName = restaurantName;
        }
        public void setRestaurantName(String restaurantName)
        {
            this.restaurantName = restaurantName;
        }
        String getRestaurantName()
        {
            return restaurantName;
        }
        public void addDrink(Drinks d) {
        }
        public void removeDrink(Drinks d) {
        }
        public void showDrink(){
        }
        public void addBurger(Burger b)
        { }
        public void removeBurger(Burger b)
        { }
        public void showBurger()
        { }
        public void addPizza(Pizza p)
        { }
        public void removePizza(Pizza p)
        { }
        public void showPizza()
        { }
    }
    public class Food : Resturant
    {
        protected string name;
        protected string[] ingredients;
        protected double price;
        protected float calories; public Food() { }
        public Food(string name, string[] ingredients, double price, float calories)
        {
            this.name = name;
            this.ingredients = ingredients;
            this.price = price;
            this.calories = calories;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setIngredients(string[] ingredients)
        {
            this.ingredients = ingredients;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }
        public void setCalories(float calories)
        {
            this.calories = calories;
        }
        public string getName()
        {
            return this.name;
        }
        public string[] getIngredients()
        {
            return this.ingredients;
        }
        public double getPrice()
        {
            return this.price;
        }
        public float getCalories()
        {
            return this.calories;
        }
        public void removeIngredient(string ingredient)
        {
            for (int i = 0; i < this.ingredients.Length; i++)
            {
                if (this.ingredients[i] == ingredient)
                {
                    this.ingredients[i] = null;
                    break;
                }
            }
        }
        public void addIngredient(string ingredient)
        {
            for (int i = 0; i < this.ingredients.Length; i++)
            {
                if (this.ingredients[i] == null)
                {
                    this.ingredients[i] = ingredient;
                    break;
                }
            }
        }
        public void showDetails()
        { }
    }
    public class Drinks : Food
    {
        protected string type;
        protected int sizeInLitter; public Drinks() { }
        public Drinks(string name, string[] ingredients, double price, float calories, string type, int sizeInLitter)
        : base(name, ingredients, price, calories)
        {
            this.type = type;
            this.sizeInLitter = sizeInLitter;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public void setSize(int sizeInLitter)
        {
            this.sizeInLitter = sizeInLitter;
        }
        public string getType()
        {
            return this.type;
        }
        public int getSize()
        {
            return this.sizeInLitter;
        }
    }
    public class Burger : Food
    {
        protected int numberOfPatty; public Burger() { }
        public Burger(string name, string[] ingredients, double price, float calories, int numberOfPatty)
        : base(name, ingredients, price, calories)
        {
            this.numberOfPatty = numberOfPatty;
        }
        public void setNumberOfPatty(int numberOfPatty)
        {
            this.numberOfPatty = numberOfPatty;
        }
        public int getNumberOfPatty()
        {
            return this.numberOfPatty;
        }
        public void showDetails()
        {
            Console.WriteLine("Burger Name: " + getName());
            Console.WriteLine("Ingredients: ");
            foreach (string ingredient in getIngredients())
            {
                if (ingredient != null)
                {
                    Console.WriteLine(" " + ingredient);
                }
            }
            Console.WriteLine("Price: $" + getPrice());
            Console.WriteLine("Calories: " + getCalories());
            Console.WriteLine("Number of Patty: " + getNumberOfPatty());
        }
    }
    public class Pizza : Food
    {
        private int sizeInInches; public Pizza() { }
        public Pizza(string name, string[] ingredients, double price, float calories, int sizeInInches)
        : base(name, ingredients, price, calories)
        {
            this.sizeInInches = sizeInInches;
        }
        public void setSize(int sizeInInches)
        {
            this.sizeInInches = sizeInInches;
        }
        int getSize()
        {
            return sizeInInches;
        }
        public void showDetails()
        {
            Console.WriteLine("Name: " + getName());
            Console.WriteLine("Ingredients: ");
            foreach (string ingredient in getIngredients())
            {
                if (ingredient != null)
                {
                    Console.WriteLine(" " + ingredient);
                }
            }
            Console.WriteLine("Price: $" + getPrice());
            Console.WriteLine("Calories: " + getCalories());
            Console.WriteLine("Size of pizza " + getSize());
        }
        public class Start
        {
            public static void Main()
            {
                string[] ingred = new string[5] { "water", "sugar", "caffeine", "phosphoric acid", "caramel color" };
                Drinks d1 = new Drinks(" Juice", new string[] { " juice concentrate", "water", "sugar" }, 2.49, 120, "juice", 3);
                Drinks d2 = new Drinks("Orange Juice", new string[] { "orange juice concentrate", "water", "sugar" }, 2.49, 120, "juice", 3);
                Drinks d3 = new Drinks("7up", new string[] { "sugar", "water" }, 2.50, 150, "soft drink", 1);


                Console.WriteLine("DRINK ITEMS :\n");

                Console.WriteLine("Drink 1: ");

                d1.showDetails();

                Console.WriteLine("Drink 2 :");
                d2.showDetails();


                Console.WriteLine("Drink 3: ");

                d3.showDetails();

                Console.WriteLine();
                Console.WriteLine("BURGERS ITEMS :\n");

                Burger b1 = new Burger("big Burger", new string[] { "wheat", "vegetablel oil", "Beef", "cheese" }, 400, 400, 2);
                Burger b2 = new Burger("spicy Burger", new string[] { "wheat", "vegetablel oil", "Beef", "cheese", "Chili" }, 400, 400, 2);

                Burger b3 = new Burger("light burger", new string[] { "beef patty", "lettuce", "tomato", "onions", "pickles" }, 5.00, 600, 2);


                Console.WriteLine("Burger 1 : ");
                b1.showDetails();
                Console.WriteLine();
                Console.WriteLine("Burger 2 : ");
                b2.showDetails();
                Console.WriteLine();

                Console.WriteLine("PIZZA ITEMS:\n");


                Console.WriteLine();
                Pizza p1 = new Pizza("Alfa Pizza", new string[] { "chicken", "roasted red peppers", "artichokes", "olive" }, 400, 100, 12);
                Pizza p2 = new Pizza("California Pizza", new string[] { "chicken", "peanut sauce", "artichoke hearts", "goat cheese" }, 400, 100, 12);
                Pizza p3 = new Pizza("spicy Pizza", new string[] { "chicken", "hot sauce", "artichoke hearts", "mogila cheese" }, 350, 99, 11);

                Console.WriteLine("Pizza 1 : ");
                p1.showDetails();
                Console.WriteLine();

                Console.WriteLine("Pizza 2 : ");
                p2.showDetails();
                Console.WriteLine();

                Console.WriteLine("Pizza 3 : ");
                p3.showDetails();
                Console.WriteLine();

                Console.ReadKey();
            }
        }
    }
}