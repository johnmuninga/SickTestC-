using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Package
    {
        protected int weight;
        protected char method;

        public Package(int weight, char method)
        {
            this.weight = weight;
            this.method = method;
        }

        public double calcCost()
        {
            double cost = 0.0;

            if (weight <= 8)
            {
                switch (method)
                {
                    case 'A': cost = 2.00; break;
                    case 'T': cost = 1.50; break;
                    case 'M': cost = 0.50; break;
                }
            }
            else if (weight <= 16)
            {
                switch (method)
                {
                    case 'A': cost = 3.00; break;
                    case 'T': cost = 2.35; break;
                    case 'M': cost = 1.50; break;
                }
            }
            else // 17 and more
            {
                switch (method)
                {
                    case 'A': cost = 4.50; break;
                    case 'T': cost = 3.25; break;
                    case 'M': cost = 2.15; break;
                }
            }

            return cost;
        }

        public void display()
        {
            Console.WriteLine($"Weight: {weight} kg");
            Console.WriteLine($"Shipping Method: {method}");
            Console.WriteLine($"Shipping Cost: {calcCost()}");
        }

        public abstract double increaseCost();
    }
}
