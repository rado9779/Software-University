using System;
using System.Collections.Generic;
using System.Text;

namespace _03.ShoppingSpree.Models
{
    public class Person
    {
        private string name;
        private decimal money;

        public Person(string name,decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.BagOfProducts = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        private ICollection<Product> BagOfProducts { get;  set; }

        public bool CanBuyAProduct(Product product)
        {
            if (product.Cost <= this.Money)
            {
                this.BagOfProducts.Add(product);
                this.Money -= product.Cost;
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (this.BagOfProducts.Count == 0)
            {
                sb.AppendLine($"{this.Name} - Nothing bought");
            }
            else
            {
                List<string> result = new List<string>();
                foreach (var item in BagOfProducts)
                {
                    result.Add(item.Name);
                }
                sb.AppendLine($"{this.Name} - {string.Join(", ", result)}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
