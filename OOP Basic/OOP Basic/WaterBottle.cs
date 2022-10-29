using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basic
{
    internal class WaterBottle
    {
       private double capacity;
       private double waterAmount;
       private string color;

       public WaterBottle(string color, double capacity=200)
        {
            this.color = color;
            this.capacity = capacity;
            IsOpen = true;
        }
        ~WaterBottle()
        {
            this.IsOpen = false;
            this.capacity=0;
            this.color = null;
            this.waterAmount = 0;
        }
        internal void AddWater(double amount)
        {
            Console.WriteLine("Called with Dobule ");
            if(amount >0 && amount+this.waterAmount <capacity)
                this.waterAmount += amount;
        }
        internal void AddWater(int amount)
        {
            Console.WriteLine("Called with Int ");
            if (amount > 0 && amount + this.waterAmount < capacity)
                this.waterAmount += amount;
        }
        public double WaterAmount
        {
            get { return this.waterAmount; }
            set
            {
                if (value > 0 && value <= capacity)
                    this.waterAmount = value;
            }
        }
        public bool IsOpen
        {
            get; set;
        }
        public string Color
        {
            get { return this.color; }
        }
        public void ShowBottoleInformation()
        {
            Console.WriteLine($"Color of the bottle is {this.color}");
            Console.WriteLine($"Amount of water is {this.waterAmount} L");
        }

        
    }
}
