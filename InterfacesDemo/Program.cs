using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }

            ISalary[] salaries = new ISalary[2]
            {
                new Worker(),
                new Manager()
            };

            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }

            Console.ReadLine();
        }
    }

    interface IWorker
    {
        void Work();
    }
    
    //SOLID, Interface Segregation
    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manages Eats");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager Gets Salary");
        }

        public void Work()
        {
            Console.WriteLine("Manager Works");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker Eats");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker Gets Salary");
        }

        public void Work()
        {
            Console.WriteLine("Worker Works");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Works");
        }
    }
}


