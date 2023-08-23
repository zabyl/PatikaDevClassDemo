using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EncapsulationDemo
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
        private string _name;
        private int _age;
        private string _department;

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Department { get => _department; set => _department = value; }

        public Worker(string name, int age, string department)
        {
            Name = name;
            Age = age;
            Department = department; 
        }
        public void PrintWorker()
        {
            Console.WriteLine($"Worker name: {Name}" +
                $"\nAge: {Age}" +
                $"\nDepartment: {Department}");
        }
    }
}
