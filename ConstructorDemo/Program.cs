using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker("Jane Doe", 25, "Unknown");
            worker.PrintWorker();
        }
    }

    class Worker
    {
        public string Name;
        public int Age;
        public string Department;

        public Worker(string name, int age, string department)
        {
            this.Name = name;
            this.Age = age;
            this.Department = department;
        }

        public void PrintWorker()
        {
            Console.WriteLine($"Worker name: {Name}" +
                $"\nAge: {Age}" +
                $"\nDepartment: {Department}");
        }
    }
}
