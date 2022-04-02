using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Product
    {
        protected string name;

        public string Name { get => this.name; }

        public virtual void Print(string prefix)
        {
            Console.WriteLine($"Details - name: {name}.");
        }
    }
}
