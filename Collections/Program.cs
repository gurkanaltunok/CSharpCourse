using System;
using System.Collections;
using System.Collections.Generic;



namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "masa");
            dictionary.Add("computer","bilgisayar");

            Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("computer"));

        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            //Console.WriteLine(cities.Contains("Adana"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Gürkan" });
            //customers.Add(new Customer { Id = 2, FirstName = "Engin" });

            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Gürkan" },
                new Customer { Id = 2, FirstName = "Engin" }
            };

            var customer1 = new Customer
            {
                Id = 3,
                FirstName = "Oğuz"
            };

            customers.Add(customer1);
            customers.AddRange(new Customer[2]
            {
                new Customer{Id = 4, FirstName= "Ahmet" },
                new Customer{Id=5, FirstName = "Mehmet"}
            });

            //customers.Clear();

            //Console.WriteLine(customers.Contains(new Customer {Id = 1, FirstName = "Gürkan" }));

            Console.WriteLine(customers.Contains(customer1));

            var index = customers.IndexOf(customer1);

            Console.WriteLine("Index : {0}", index);

            customers.Insert(0, customer1);

            customers.Remove(customer1); //Bulduğu ilk değeri siler
            customers.Remove(customer1);

            customers.RemoveAll(c => c.FirstName == "Gürkan");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            var count = customers.Count;
            Console.WriteLine("Count : {0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            cities.Add("Adana");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            cities.Add("Tekirdağ");

            cities.Add(1);
            cities.Add("A");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
