using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCLasswork
{

    public class Vehicle
    {
        public string vehiclesbrand;
        public int vehiclesmodel;
        public int manufactureyear;
        public Vehicle() { }
        public Vehicle(string vehiclebrand, int vehiclesmodel, int manufactureyear)
        {
            this.vehiclesbrand = vehiclesbrand;
            this.vehiclesmodel = vehiclesmodel;
            this.manufactureyear = manufactureyear;
        }
        
       
        public void VehiclesStartEngine()
        {
            Console.WriteLine("Vehicle has started !");
        }
       
    }
   public class Car : Vehicle
    {
        int CarDoor_numbers { set; get; }
        public Car() { }
        public Car( string vehiclebrand, int vehiclesmodel, int manufactureyear ,int CarDoor_numbers):base (vehiclebrand,vehiclesmodel,manufactureyear)
        { 

        this.CarDoor_numbers= CarDoor_numbers;

         }
      

        public void CarStartEngine()
        {
            Console.WriteLine("Car has started !");
        }

        public void showinfo()
        {
            Console.WriteLine("Car: :\n");
            Console.WriteLine("Brand :" +vehiclesbrand);
            Console.WriteLine("model :"+vehiclesmodel );
            Console.WriteLine("Manufacture_year :"+manufactureyear );
            Console.WriteLine("CarDoor_Number : :" +CarDoor_numbers);
            
        }
    }
    class Motorcycle : Vehicle
    {
        public int Engine_Displacement { get; set; }
        public Motorcycle(string vehiclebrand, int vehiclesmodel, int manufactureyear, int Engine_Displacement) : base(vehiclebrand, vehiclesmodel, manufactureyear)
        {
            this.Engine_Displacement = Engine_Displacement;
        }
       
        public void StartEngine()
        {
            Console.WriteLine("motorcycle engine has started!");
        }
        public void showinfo()
        {
            Console.WriteLine("Motorcycles: \n");
            Console.WriteLine("Brand :"+vehiclesbrand);
            Console.WriteLine("model :"+vehiclesmodel);
            Console.WriteLine("Manufacture_year :"+manufactureyear);
            Console.WriteLine("Engine_displacment :"+Engine_Displacement);

        }
    }
    class truck : Vehicle
    {
        public int Maximum_Weight { get; set; }
        public truck(string vehiclebrand, int vehiclesmodel, int manufactureyear, int maximum_Weight) : base(vehiclebrand, vehiclesmodel, manufactureyear)
        {
            Maximum_Weight = maximum_Weight;
        }

        public void TruckStartEngine()
        {
            Console.WriteLine("truck engine has started!");
        }
        public void showinfo()
        {
            Console.WriteLine("Truck :\n");
            Console.WriteLine("Brand :"+vehiclesbrand);
            Console.WriteLine("model :"+vehiclesmodel);
            Console.WriteLine("Manufacture_year :"+manufactureyear);
            Console.WriteLine("Maximum Weight :"+Maximum_Weight);

        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("axio",2020,2021,4);
          
            Motorcycle m1 = new Motorcycle("RTR 4v",2020,2021,160);

            truck t1 = new truck("volvo", 2018, 2020, 15000);

            c1.showinfo();
            m1.showinfo();
            t1.showinfo();
            Console.WriteLine();
            c1.CarStartEngine();
            m1.StartEngine();
            t1.TruckStartEngine();
            Console.ReadLine();
            
        }
    }
}
