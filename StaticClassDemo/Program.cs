using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StaticClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Worker count is: {Worker.WorkerCount}");

            Worker worker = new Worker("John Doe", 25, "Unknown");
            worker.PrintWorker();

            Console.WriteLine($"Worker count is: {Worker.WorkerCount}");

            Console.WriteLine();
            Console.WriteLine(Operation.Sum(156,5274));
            Console.WriteLine(Operation.Multiply(121,121));
            Console.WriteLine(Operation.Divide(256,8));
            Console.WriteLine(Operation.Power(17,5));

            Console.ReadLine();
        }
    }

    class Worker
    {
        private static int _workerCount;

        public static int WorkerCount { get => _workerCount; }

        private string _name;
        private int _age;
        private string _department;

        static Worker()
        {
            _workerCount = 0;
        }
        public Worker(string name, int age, string department)
        {
            _name = name;
            _age = age;
            _department = department;
            _workerCount++;
        }

        public void PrintWorker()
        {
            Console.WriteLine($"Worker name: {_name}" +
                $"\nAge: {_age}" +
                $"\nDepartment: {_department}");
        }

    }

    static class Operation
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {
            return x / y;
        }

        public static double Power(int x, int y)
        {
            return Math.Pow(x, y);
        }
    }
}
