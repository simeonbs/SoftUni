using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;
        
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            bag = new List<Product>();
        } //ctor

        public string Name
        {
            get => this.name;
            protected set
            {
                if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Money
        {
            get => this.money;
            protected set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public List<Product> Bag => this.bag;

        public void BuyProduct(Product product)
        {
            if (this.Money < product.Cost)
            {
                throw new Exception($"{this.Name} can't afford {product.Name}");
            }

            this.Money -= product.Cost;
            this.bag.Add(product);
        }

        public override string ToString()
        {
            string productsOutput = this.Bag.Count > 0 ? String.Join(", ", this.Bag) : "Nothing bought";
            return $"{this.Name} - {productsOutput}";
        }
    }
}
