using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Shop
    {
        protected string name;
        protected Person[] people;
        protected Product[] products;

        public string Name { get => this.name; }
        public Product[] Products { get => this.products; }
        public Person[] People { get => this.people; }


        public Shop(string name, Person[] people, Product[] products)
        {
            this.name = name;
            this.people = people;
            this.products = products;
        }

        public void Print()
        {
            Console.WriteLine("-- People: --");

            foreach (Person id in people)
            {
                Console.WriteLine($"\t{id.GetType().Name}: {id.Name} ({id.Age} y.o.)");

                if (id.GetType().Name == "Buyer")
                {
                    if (((Buyer)id).Products.Count > 0) { Console.WriteLine("\t\t-- Products: --"); }

                    foreach (Product pr in ((Buyer)id).Products)
                    {
                        pr.Print("\t\t");
                    }

                }


            }
            Console.WriteLine("-- Products: --");
            foreach (Product id in products)
            {
                id.Print("\t");



            }
        }
        }
    }
