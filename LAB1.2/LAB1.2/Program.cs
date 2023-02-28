using LAB1._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LAB1._2
{
    public class Food
    {

       public string name;
        string[] ingredients;
        double price;
        float calories;

        public Food()
        {
           
        }


        public Food(String name, String[] ingredients, double price, float calories)
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

        public string getname()
        {
            return this.name;
        }

        void setingredients(string[] ingredients)
        {
            this.ingredients = ingredients;
        }
        public String[] getIngredients()
        {
            return this.ingredients;
        }
        void setdouble(double price)
        {
            this.price = price;
        }
        public double getPrice()
        {
            return this.price;
        }
        void setCalories(float calories)
        {
            this.calories = calories;
        }
        public float getCalories()
        {
            return this.calories;
        }
        void removeIngredient(string ingredient)
        {

        }
        void AddIngredient(string ingredient)
        {

        }




        public void showDetails()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Ingredients  : " +string.Join(",",this.ingredients));
            Console.WriteLine("price  :" + price);
            Console.WriteLine("calories :" + calories);
        }

       
    }
}

        class program { 
        static void Main(string[] args) {

        
                Food f1 = new Food("Ice cream",new string[] {"water","milk","sugar"},6.0,24);
                Food f2 = new Food("chocolate", new string[] {"water","milk","sugar"},6.0,24);
        





         f1.showDetails();
         f2.showDetails();

       

        Console.ReadLine();


        
        }
        

        }
    

