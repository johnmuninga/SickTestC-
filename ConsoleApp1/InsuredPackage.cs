using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class InsuredPackage: Package
    {
        public InsuredPackage(int weight, char method) : base(weight, method) { }

        public override double increaseCost()
        {
            double originalCost = calcCost();
            double additionalCost = 0.0;

            if (originalCost <= 1.00)
                additionalCost = 2.45;
            else if (originalCost <= 3.00)
                additionalCost = 3.95;
            else // 3.01 and over
                additionalCost = 5.55;

            return originalCost + additionalCost;
        }

        public new void display()
        {
            base.display();
            Console.WriteLine($"Total Cost (with insurance): {increaseCost()}");
        }
    }
}
