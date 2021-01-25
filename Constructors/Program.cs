﻿using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.List();

            Product product = new Product {Id = 1, Name = "Laptop" };
            Product product2 = new Product(2, "Computer");

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            EmployeeManager employeeManager2 = new EmployeeManager(new FileLogger());
            employeeManager2.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 10;
            //Console.WriteLine(Teacher.Number);

            Utilities.Validate();

            Manager.DoSometing();
            Manager manager = new Manager();
            manager.DoSomething2();

        }
    }

    class CustomerManager
    {
        private int _count=15;
        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {

        }

        public void List()
        {
            Console.WriteLine("Listed {0} items",_count) ;
        }

        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }

    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;

        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }

    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }

    class PersonManager:BaseClass
    {
        public PersonManager(string entity):base(entity)
        {

        }

        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }

    static class Teacher
    {
        public static int Number { get; set; }
    }

    static class Utilities
    {
        static Utilities()
        {
            //Static bir nesnede mutlaka kullanılmasını istediğimiz kodu bu blok şeklinde kullanabiliriz
        }

        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        public static void DoSometing()
        {
            Console.WriteLine("Done");
        }

        public void DoSomething2()
        {
            Console.WriteLine("Done 2");
        }
    }
}