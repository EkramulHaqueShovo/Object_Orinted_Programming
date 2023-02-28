using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opp2Inheritance
{

    class food
    {
        public string name;
        public string[] ingredients;
        public double price;
        public float calories;
        public food() { }
        public food(string name, string[] ingredients, double price, float calories)
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
        void setingredient(string[] ingrdients)
        {
            this.ingredients = ingrdients;
        }
        void setprice(double price)
        {
            this.price = price;
        }
        void setcalories(float calories)
        {
            this.calories = calories;
        }
        public string getName()
        {
            return this.name;
        }
        public string[] getingredients()
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

        void removeingredient(string ingredient)
        {

        }
        void addingredient(string ingredient)
        {

        }

        public void showDetails()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Ingredients  : " + string.Join(",", this.ingredients));
            Console.WriteLine("price  :" + price);
            Console.WriteLine("calories :" + calories);
        }


    }

    class Drink : food
    {
        string type { set; get; }
        int sizeInLitter { set; get; }
        Drink() { }
        Drink(string name, string[] ingredients, double price, float calories, string type, int sizeInLitter)
        {
            this.name = name;
            this.ingredients = ingredients;
            this.price = price;
            this.calories = calories;
            this.type = type;
            this.sizeInLitter = sizeInLitter;

        }
        public new void showDetails()
        {
            base.showDetails();
            Console.WriteLine("Size In Litter: "+sizeInLitter);



        }
        class Burger : food
        {
            int numberOfPatty { set; get; }
            public Burger()
            {

            }
            public Burger(String name, String[] ingredients, double price, float calories, int numberOfPatty)
            {
                this.numberOfPatty = numberOfPatty;
            }

            public new void showDetails()
            {
                base.showDetails();
                Console.WriteLine(" NUmber Of patty: "+numberOfPatty);


            }
        }

        class Pizza: food
        {
            int sizeInInches { set; get; }
            public Pizza()
            {

            }
            public Pizza(String name, String[] ingredients, double price, float calories, int sizeInInches)
            {
                this.sizeInInches = sizeInInches;
            }

            public new void showDetails()
            {
                base.showDetails();
                Console.WriteLine(" sizeInInches: "+sizeInInches);


            }
        }
        internal class Program
        {
            static void Main(string[] args) {


                Drink d1 = new Drink("Lemon", new string[] { "water", "lemon", "sugar" }, 30.5, 50, "Juice", 50);
             

                Burger b1 = new Burger("Beef Burger", new string[] { "beef", "Tomatoo", "Chess" }, 34.5, 500, 33);
            
              
                Pizza p1 = new Pizza("BasicPiza",new string[] {"sauch","dough","Chess"},203,30,50);

                d1.showDetails();
                b1.showDetails();
                p1.showDetails();

                Console.ReadLine();



            }
           
        }
    }
}

