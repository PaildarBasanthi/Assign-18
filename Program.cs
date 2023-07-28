using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentonElectronicdevices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Device\n1.Smartphone 2.Laptop");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Smartphone smartphone = new Smartphone(true);
                    Console.WriteLine("Device Connected Successfully   :" + smartphone.Connect());
                    Console.WriteLine("It takes to Charge " + smartphone.Charge(45) + " minutes.");
                    Console.WriteLine(smartphone.Display());
                    break;
                case 2:
                    Laptop laptop = new Laptop(true);
                    Console.WriteLine("Device Connected Successfully   :" + laptop.Connect());
                    Console.WriteLine("It takes to Charge " + laptop.Charge(45) + " minutes.");
                    Console.WriteLine(laptop.Display());
                    break;
                default:
                    throw new Exception("Invalid input Format");
            }
            Console.ReadKey();

        }
    }
}
