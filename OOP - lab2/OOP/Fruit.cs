using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Fruit : Product
    {
        protected int count;

        public int Count { get => this.count; }

        public Fruit(string name, int count)
        {
            this.name = name;
            this.count = count;
        }

        public override void Print(string prefix)
        {
            Console.WriteLine($"{prefix}{name}, {count} in stock.");
        }
    }
}
