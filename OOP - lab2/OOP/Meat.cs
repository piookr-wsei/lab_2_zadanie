using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Meat : Product
    {
        protected double weight;

        public double Count { get => this.weight; }

        public Meat(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public override void Print(string prefix)
        {
            Console.WriteLine($"{prefix}{name}, {weight}kg in stock.");
        }

    }
}
