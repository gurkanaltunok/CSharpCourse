using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        protected int Id { get; set; } // protected = private ın bütün özelliklerini kapsar. Ek olarak intheritance seviyesine taşır.
        //private int Id { get; set; } // private = class seviyesinde

        public void Save()
        {
            Id
        }

        public void Delete()
        {
            Id
        }
    }

    class Student : Customer
    {
        public void Save2()
        {
            Id
        }
    }

    // Class default acceess modifier is "internal" => Bağlı bulduğu projede (assembly) de referans ihtiyacı olmadan kullanılabilir.
    public class Course
    {
        public string Name { get; set; }
    }

}
