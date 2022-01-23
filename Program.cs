using System;
using System.Collections.Generic;
using System.Globalization;
using Store.src.Employee;
using Store.src.Enum;

namespace BuyProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintWork();

            PrintProduct();






        }

        static void PrintWork()
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level: (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name : " + worker.EmployeeName);
            Console.WriteLine("Department: " + worker.DepartmentName.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }


        static void PrintProduct()
        {

            List<Product> listProtuct = new List<Product>();

            Product product = new Product("0001", "PC - ", 10, 1000, IVAs.IvaNormal);
            Product product1 = new Product("0002", "PC -2 ", 11, 1200, IVAs.IvaNormal);
            Product product2 = new Product("0003", "PC -3 ", 12, 1300, IVAs.IvaReduzido);
            listProtuct.Add(product);
            listProtuct.Add(product1);
            listProtuct.Add(product2);
            listProtuct.Add(product);
            listProtuct.Add(product1);
            listProtuct.Add(product2);
            // Console.WriteLine("Pro " + product);



            CarBuy carBuy = new CarBuy(listProtuct, DateTime.Now);

            carBuy.ShowListItemCar();
            //Console.WriteLine(" " + carBuy);

        }
    }
}
