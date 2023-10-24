using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Package[] packages = new Package[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter details for package {i + 1}:");

                Console.Write("Enter weight (in kg): ");
                int weight = int.Parse(Console.ReadLine());

                Console.Write("Enter shipping method (A for air, T for truck, M for mail): ");
                char method = char.ToUpper(Console.ReadLine()[0]);

                packages[i] = new InsuredPackage(weight, method);
            }

            Console.WriteLine("\nPackage Details:");
            foreach (var package in packages)
            {
                package.display();
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
