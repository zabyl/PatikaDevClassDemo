using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassFieldProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.Name = "John Doe";
            worker.Age = 25;
            worker.Department = "Unknown";

            worker.PrintWorker();

            Console.ReadLine();
        }
    }

    class Worker
    {
        public string Name;
        public int Age;
        public string Department;

        public void PrintWorker()
        {
            Console.WriteLine($"Worker name: {Name}" +
                $"\nAge: {Age}" +
                $"\nDepartment: {Department}");
        }
    }
}
